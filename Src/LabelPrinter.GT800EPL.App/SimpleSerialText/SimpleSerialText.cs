using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using SerialText.Utilities;

namespace SerialText
{
    public class SimpleSerialText : IDisposable
    {
        #region Dispose
        // Implement IDisposable. 
        // Do not make this method virtual. 
        // A derived class should not be able to override this method. 
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            // This object will be cleaned up by the Dispose method. 
            // Therefore, you should call GC.SupressFinalize to 
            // take this object off the finalization queue 
            // and prevent finalization code for this object 
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios. 
        // If disposing equals true, the method has been called directly 
        // or indirectly by a user's code. Managed and unmanaged resources 
        // can be disposed. 
        // If disposing equals false, the method has been called by the 
        // runtime from inside the finalizer and you should not reference 
        // other objects. Only unmanaged resources can be disposed. 
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called. 
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed 
                // and unmanaged resources. 
                if (disposing)
                {
                    // Dispose managed resources.

                    if (this.sp != null)
                    {
                        this.sp.Close();
                        this.sp.Dispose();
                    }
                }

                // Call the appropriate methods to clean up 
                // unmanaged resources here. 
                // If disposing is false, 
                // only the following code is executed.                

                // Note disposing has been done.
                disposed = true;
            }
        }

        #endregion

        #region Port properties
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBits { get; set; }
        public Handshake Handshake { get; set; }
        #endregion

        #region Class properties
        private object _Lock = new object();
        private SerialPort sp;
        public SerialPort Port { get { return sp; } }
        public bool PortNotFound { get; private set; }
        private LogFile.Log _Log;
        public string LastBusStatus;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="parity"></param>
        /// <param name="stopBits"></param>
        public SimpleSerialText(string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits, Handshake handshake)
        {
            this.PortName = portName;
            this.BaudRate = baudRate;
            this.DataBits = dataBits;
            this.Parity = parity;
            this.StopBits = stopBits;
            this.Handshake = handshake;

            if (_Log == null) _Log = new LogFile.Log(@"C:\Log\Serial", @"Serial Text");
            if (sp == null) this.sp = new SerialPort();
        }

        ~SimpleSerialText() { this.Dispose(); }

        public Response Open()
        {
            try
            {
                /* -------------------------------------------------------------
                 * Port name validation
                 * -------------------------------------------------------------*/
                this.PortName = (this.PortName ?? "").ToUpper();
                PortNotFound = false;
                if (!IsPortFound(this.PortName))
                {
                    Response res = Responses.PortNotFound(this.PortName);
                    _Log.AppendText(res.Message);
                    PortNotFound = true;
                    return res;
                }
                else // มี Port -> เปิดพอร์ต
                {
                    /* -------------------------------------------------------------
                     * Open port with mobus class
                     * -------------------------------------------------------------*/
                    lock (_Lock)
                    {
                        if (this.Open(this.PortName, this.BaudRate, this.DataBits, this.Parity, this.StopBits, this.Handshake))
                        {
                            Response res = Responses.OpenSuccess(this.PortName);
                            _Log.AppendText(res.Message);
                            return res;
                        }
                        else
                        {
                            Response res = Responses.OpenFailed;
                            _Log.AppendText(res.Message);
                            return res;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _Log.AppendText(ex.Message);
                return Responses.OpenFailed;
            }
        }

        #region Open / Close Procedures
        public bool Open(string portName, int baudRate, int databits, Parity parity, StopBits stopBits, Handshake handshake)
        {
            //Ensure port isn't already opened:
            if (!sp.IsOpen)
            {
                //Assign desired settings to the serial port:
                sp.PortName = portName;
                sp.BaudRate = baudRate;
                sp.DataBits = databits;
                sp.Parity = parity;
                sp.StopBits = stopBits;
                sp.Handshake = handshake; // more assign
                //These timeouts are default and cannot be editted through the class at this point:
                sp.ReadTimeout = 1000;
                sp.WriteTimeout = 300;

                try
                {
                    //sp.Close();
                    sp.Open();
                    System.Threading.Thread.Sleep(250);
                }
                catch (Exception err)
                {
                    LastBusStatus = "Error opening " + portName + ": " + err.Message;
                    return false;
                }
                LastBusStatus = portName + " opened successfully";
                return true;
            }
            else
            {
                LastBusStatus = portName + " already opened";
                return false;
            }
        }
        public bool Close()
        {
            //Ensure port is opened before attempting to close:
            if (sp.IsOpen)
            {
                try
                {
                    sp.Close();
                }
                catch (Exception err)
                {
                    LastBusStatus = "Error closing " + sp.PortName + ": " + err.Message;
                    _Log.AppendText(LastBusStatus);
                    return false;
                }
                LastBusStatus = sp.PortName + " closed successfully";
                _Log.AppendText(LastBusStatus);
                return true;
            }
            else
            {
                LastBusStatus = sp.PortName + " is not open";
                _Log.AppendText(LastBusStatus);
                return false;
            }
        }
        #endregion

        public Response Read()
        {
            try
            {
                List<StringBuilder> sbList = new List<StringBuilder>();
                int byteIncoming;
                int iByte = 0;
                int LLLL = 0;
                int pcLRC = 0, LRC = 0;
                bool isMessageComming = false;
                bool receiving = true;
                bool isTimeout = false;
                bool isExceed = false;
                bool LRC_OK = false;
                Stopwatch sw = new Stopwatch();

                lock (_Lock)
                {
                    // ---------------------------------------------------------------------
                    // 1. Check serial avariable
                    // ---------------------------------------------------------------------
                    if (!(0 < sp.BytesToRead)) { return Responses.NoBytesToRead; } // -->(END)

                    // ---------------------------------------------------------------------
                    // Read response bytes
                    // ---------------------------------------------------------------------
                    // System.Threading.Thread.Sleep(150);
                    sw.Reset(); sw.Start(); isTimeout = false;
                    receiving = true; isExceed = false;
                    while (receiving)
                    {
                        System.Threading.Thread.Sleep(1);
                        try
                        {
                            byteIncoming = 0;
                            byteIncoming = sp.ReadByte();
                            iByte++;
                        }
                        catch (Exception exReceiving)
                        {
                            byteIncoming = 0;
                            if (iByte <= 0)
                                return new Response() { Code = -90, Message = exReceiving.Message, }; // -->(END)
                        } // end try

                        // <STX> = : come
                        if (byteIncoming.Equals((int)(':')))
                        {
                            sbList.Add(new StringBuilder());
                            isMessageComming = true;
                            sw.Stop(); sw.Reset(); sw.Start();
                            iByte = 0;
                        }

                        // keep ascii
                        if (20 <= byteIncoming && byteIncoming <= 0x7E && isMessageComming)
                        {
                            sbList[sbList.Count - 1].Append((char)byteIncoming);
                            pcLRC ^= byteIncoming;
                            sw.Stop(); sw.Reset(); sw.Start();
                        }

                        // <ETX> = # come
                        if (byteIncoming.Equals((int)('#')))
                        {
                            isMessageComming = false;
                            pcLRC ^= byteIncoming;
                            sw.Stop(); sw.Reset(); sw.Start();
                            LLLL = iByte;
                        }

                        // <LRC>
                        if (LLLL + 1 <= iByte && !isMessageComming)
                        {
                            LRC = byteIncoming;
                            sw.Stop(); sw.Reset(); sw.Start();

                            // Check <LRC>
                            LRC_OK = pcLRC == LRC;
                            receiving = false; break;
                        }

                        if (256 < iByte) // Check exeed
                        {
                            isExceed = true; receiving = false; break;
                        }

                        // Check timeout
                        if (1200 < sw.ElapsedMilliseconds)
                        {
                            sw.Stop(); isTimeout = true; receiving = false; break;
                        }

                    } // end while

                    // ---------------------------------------------------------------------
                    // Pos-processing
                    // ---------------------------------------------------------------------
                    // Timeout
                    if (isTimeout && sbList.Count <= 0) return Responses.PortTimeout; // -->(END) 

                    // Exceed
                    if (isExceed && sbList.Count <= 0) return Responses.InvalidInput; // -->(END)

                    // Exceed
                    if (!LRC_OK) { var res = Responses.LrcFailed; res.Message = string.Format("LRC failed! [{0}]", pcLRC); return res; }// -->(END)

                    // Success received data
                    var response = Responses.Success;
                    response.Data = sbList;
                    return response;
                    // -->(GOOD END)
                }

            }
            catch (TimeoutException tmex)
            {
                _Log.AppendText(tmex.Message);
                _Log.AppendText(tmex.StackTrace);
                return Responses.PortTimeout;
                // -->(END)
            }
            catch (Exception ex)
            {
                _Log.AppendText(ex.StackTrace);
            }

            return Responses.UnknownError;
            // -->(END)
        }

        public void Write(string text)
        {
            try
            {
                sp.Write(text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected bool IsPortFound(string portName) { return SerialPort.GetPortNames().Any(n => (n ?? "").ToLower().Equals((portName ?? "").ToLower())); }
    }
}
