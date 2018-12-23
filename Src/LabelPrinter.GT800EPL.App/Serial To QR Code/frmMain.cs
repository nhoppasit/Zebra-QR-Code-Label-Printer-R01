using QRCoder;
using SerialText.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using Zebra.Sdk.Printer.Discovery;

namespace Serial_To_QR_Code
{
    public partial class frmMain : Form
    {
        private delegate void VoidDelegate();

        public void PostStatus(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new VoidDelegate(delegate ()
                {
                    lblStatus.Text = text;
                }));
            }
            else
            {
                lblStatus.Text = text;
            }
        }

        public void PostPrinterName(string e)
        {
            if (lblPrinter.InvokeRequired)
            {
                lblPrinter.Invoke(new VoidDelegate(delegate ()
                {
                    lblPrinter.Text = e;
                }));
            }
            else
            {
                lblPrinter.Text = e;
            }
        }

        public void PostPrinterStatus()
        {
            if (chkPrinterNotFound.InvokeRequired)
            {
                chkPrinterNotFound.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.PrinterNotFound) chkPrinterNotFound.Checked = true;
                    else chkPrinterNotFound.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.PrinterNotFound) chkPrinterNotFound.Checked = true;
                else chkPrinterNotFound.Checked = false;
            }

            // Ready
            if (chkPrinterReady.InvokeRequired)
            {
                chkPrinterReady.Invoke(new VoidDelegate(delegate ()
                {
                    chkPrinterReady.Checked = !error_Flag.Flag;
                }));
            }
            else
            {
                chkPrinterReady.Checked = !error_Flag.Flag;
            }

            // Head open
            if (chkPrinterHeadOpen.InvokeRequired)
            {
                chkPrinterHeadOpen.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Head_Open) chkPrinterHeadOpen.Checked = true;
                    else chkPrinterHeadOpen.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Head_Open) chkPrinterHeadOpen.Checked = true;
                else chkPrinterHeadOpen.Checked = false;
            }
        }

        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += FrmMain_FormClosing;
            this.Load += FrmMain_Load;
            this.btnPrint.Click += BtnPrint_Click;
            this.txtBoxQRCode.KeyPress += TxtBoxQRCode_KeyPress;

            timerPrinter.Interval = 500;
            timerPrinter.Enabled = true;

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = this.Text + " " + version;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TxtBoxQRCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                RenderQrCode(txtBoxQRCode.Text);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(txtBoxQRCode.Text);
        }

        volatile bool Printing = false;
        void Print(string e)
        {
            SlipPrinter.PrintProcess.Process(new string[] { e, "", "", "", "" });
            try
            {
                GetPrinterStatus();
                if (error_Flag.ReadFailed) GetPrinterStatus();
                if (serialText.Port.IsOpen)
                {
                    serialText.Write("Printed.\r\n");
                }
            }
            catch (Exception ex)
            {
                logText = string.Format("{0} {1}", ex.Message, ex.StackTrace);
                _Log.AppendText(logText);
                MessageBox.Show(logText);
            }
        }

        Thread tSerial;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            tSerial = new Thread(PollingLoop);
            tSerial.Start();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopFlag = true;
        }

        LogFile.Log _Log = new LogFile.Log(@"C:\Log", @"Qr Coder");

        private void RenderQrCode(string e)
        {
            QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.M;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(e, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        pictureBoxQRCode.Invoke(new Action(delegate ()
                        {
                            try
                            {
                                pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(10, Color.Black, Color.White, null, 0, 0, false);
                                this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                                this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
                                pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                                string file = string.Format(@"C:\QR\{0}.jpg", e);
                                // Save
                                using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                                {
                                    ImageFormat imageFormat = ImageFormat.Jpeg;
                                    pictureBoxQRCode.BackgroundImage.Save(fs, imageFormat);
                                    fs.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                string str = String.Format("{0} {1}", ex.Message, ex.StackTrace);
                                _Log.AppendText(str);
                                MessageBox.Show(str, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }));
                    }
                }
            }
        }

        #region SERIAL INTERFACE & POLLING

        string portName = string.Empty;
        int baudRate = 9600;
        int dataBits = 8;
        Parity parity = Parity.None;
        StopBits stopBits = StopBits.One;
        Handshake handshake = Handshake.None;

        int PollingDelay = 20;
        volatile bool StopFlag = true;
        string logText;
        object locker = new object();

        SerialText.SimpleSerialText serialText;
        private volatile bool Connecting, Running;
        Thread tRecon;

        Thread tPolling;
        void StartPolling()
        {
            tPolling = new Thread(PollingLoop);
            tPolling.Start();
        }

        public void StopPolling()
        {
            StopFlag = true; logText = "Start Polling"; _Log.AppendText(logText);
        }

        void Connect()
        {
            Connecting = true;

            int Attemps = 10;

            for (int i = 0; i < Attemps; i++)
            {
                Response serial_res = serialText.Open();
                logText = serial_res.Message; _Log.AppendText(logText);
                if (serial_res.Success)
                {
                    Connecting = false;
                    Running = true;
                    return;
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds < 300)
                {
                    if (StopFlag)
                    {
                        Connecting = false;
                        return;
                    }
                    Thread.Sleep(20);
                }
            }
            Connecting = false;
        }

        void Reconnection()
        {
            while (!Running)
            {
                Connect();
                Thread.Sleep(100);
                if (StopFlag) return;
            }
        }

        private void GenerateQrCode(string text)
        {
            string code = string.Format("{0}", text);
            this.Invoke(new Action(delegate () { txtBoxQRCode.Text = code; }));
            RenderQrCode(code);
        }

        void PollingLoop()
        {
            try
            {
                /* ----------------------------------------------------------------------------
                 * Start
                 * ----------------------------------------------------------------------------*/
                logText = "Start load cell console meter."; _Log.AppendText(logText);
                logText = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); _Log.AppendText(logText);

                /* ----------------------------------------------------------------------------
                 * port setting
                 * ----------------------------------------------------------------------------*/
                this.portName = Properties.Settings.Default.PortName;
                this.baudRate = Properties.Settings.Default.BaudRate;
                this.dataBits = Properties.Settings.Default.DataBits;
                this.parity = Properties.Settings.Default.Parity;
                this.stopBits = Properties.Settings.Default.StopBits;
                this.handshake = Properties.Settings.Default.Handshake;

                /* ----------------------------------------------------------------------------
                 * Treat load cell class with the port
                 * ----------------------------------------------------------------------------*/
                serialText = new SerialText.SimpleSerialText(portName, baudRate, dataBits, parity, stopBits, handshake);

                /* ----------------------------------------------------------------------------
                 * Connect
                 * ----------------------------------------------------------------------------*/
                logText = "Connecting..."; _Log.AppendText(logText);
                StopFlag = false;
                Connecting = true; Running = false;
                Connect();
                if (!Running || Connecting)
                {
                    tRecon = new Thread(Reconnection); // Fast response() and wait for connection here!
                    tRecon.Start();
                }

                /* ----------------------------------------------------------------------------
                 * LOOP
                 * ----------------------------------------------------------------------------*/
                SerialText.Utilities.Response serial_res;
                while (!StopFlag)
                {
                    if (Running && !Connecting)
                    {
                        //logText = "Do polling..."; _Log.AppendText(logText);

                        serial_res = serialText.Read();
                        logText = serial_res.Message;
                        //_Log.AppendText(logText);
                        if (!serial_res.Success)
                        {
                            if (serial_res.Code != 6 && serial_res.Code != 7)
                            {
                                if (!StopFlag)
                                {
                                    Running = false;
                                    tRecon = new Thread(Reconnection); // Fast response() and wait for connection here!
                                    tRecon.Start();
                                    _Log.AppendText(logText);
                                }
                            }
                            if (serial_res.Code == 7)
                            {
                                _Log.AppendText(logText);
                            }
                        }
                        else // Success
                        {
                            List<StringBuilder> ret = (List<StringBuilder>)serial_res.Data;
                            foreach (StringBuilder sb in ret)
                            {
                                Printing = true;
                                string str = (sb.ToString().Replace(":", "")).Replace("#", "");
                                GenerateQrCode(str);
                                logText = String.Format(">>> Qr Generated : {0}", str);
                                _Log.AppendText(logText);
                                PostStatus(logText);
                                Print(str);
                                Printing = false;
                            }
                        }

                        Thread.Sleep(PollingDelay);
                    }
                }

                /* ----------------------------------------------------------------------------
                 * Exit
                 * ----------------------------------------------------------------------------*/
                logText = "End the process."; _Log.AppendText(logText); PostStatus(logText);
            }
            catch (Exception ex)
            {
                /* ----------------------------------------------------------------------------
                 * Log
                 * ----------------------------------------------------------------------------*/
                logText = "Exceptional stop."; _Log.AppendText(logText);
                logText = ex.Message; _Log.AppendText(logText);
                PostStatus(logText);
            }
        }

        #endregion

        public List<DiscoveredPrinter> GetUSBPrinters()
        {
            List<DiscoveredPrinter> printerList = new List<DiscoveredPrinter>();
            try
            {
                foreach (DiscoveredUsbPrinter usbPrinter in UsbDiscoverer.GetZebraUsbPrinters())
                {
                    printerList.Add(usbPrinter);
                    _Log.AppendText(usbPrinter.ToString());
                }
            }
            catch (ConnectionException e)
            {
                _Log.AppendText($"Error discovering local printers: {e.Message}");
                error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = true;
            }

            _Log.AppendText("Done discovering local printers.");
            error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = false;
            return printerList;
        }

        public void basicPrint(string zpl)
        {
            List<DiscoveredPrinter> printerList = GetUSBPrinters();
            string ZPL_STRING = "^XA^FO50,50^A0N,50,50^FDHello World^FS^XZ";

            if (printerList.Count > 0)
            {
                // in this case, we arbitrarily are printing to the first found printer  
                DiscoveredPrinter discoveredPrinter = printerList[0];
                Connection connection = discoveredPrinter.GetConnection();
                connection.Open();
                connection.Write(Encoding.UTF8.GetBytes(ZPL_STRING));
            }
            else
                _Log.AppendText("No Printers found to print to.");
        }

        HQES_Error_Flag error_Flag = new HQES_Error_Flag();
        HQES_Warning_Flag warning_Flag = new HQES_Warning_Flag();

        public void GetPrinterStatus()
        {
            List<DiscoveredPrinter> printerList = GetUSBPrinters();

            if (printerList.Count > 0)
            {
                error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = false;
                // in this case, we arbitrarily are printing to the first found printer  
                DiscoveredPrinter discoveredPrinter = printerList[0];
                Connection connection = discoveredPrinter.GetConnection();
                connection.Open();

                PostPrinterName(discoveredPrinter.DiscoveryDataMap["MODEL"]);

                string spaperout = "~HQES";

                string terminator = "\x03";  // hex ETX

                byte[] buffer2 = ASCIIEncoding.ASCII.GetBytes(spaperout);

                byte[] buffer3 = connection.SendAndWaitForResponse(buffer2, 3000, 500, terminator);

                if (0 == buffer3.Length)
                {
                    error_Flag.ReadFailed = warning_Flag.ReadFailed = true;
                    _Log.AppendText("Read printer status failed!");
                    return;
                }
                else
                {
                    // -----------------------------------------------------
                    // Convert buffer
                    // -----------------------------------------------------
                    error_Flag.ReadFailed = warning_Flag.ReadFailed = false;
                    string converted = Encoding.UTF8.GetString(buffer3, 0, buffer3.Length);
                    _Log.AppendText(converted);
                    string status = string.Empty;
                    if (2 != buffer3[0])
                    {
                        _Log.AppendText("Read in extra data from some other command!");
                        string[] astr = converted.Split('\x02');
                        status = astr[1];
                    }
                    else
                    {
                        status = converted;
                    }

                    // -----------------------------------------------------
                    // Keep error and warning text
                    // -----------------------------------------------------
                    string[] lines = status.Split('\n');
                    string error = string.Empty;
                    string warning = string.Empty;
                    foreach (string s in lines)
                    {
                        if (s.Contains("ERRORS:"))
                        {
                            error = s;
                        }
                        if (s.Contains("WARNINGS:"))
                        {
                            warning = s;
                        }
                    }

                    // -----------------------------------------------------
                    // Extract Error
                    // -----------------------------------------------------
                    error_Flag.Extract(error);

                    // -----------------------------------------------------
                    // Extract Warning
                    // -----------------------------------------------------
                    warning_Flag.Extract(warning);
                }
            }
            else
            {
                error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = true;
                error_Flag.Flag = warning_Flag.Flag = true;
                _Log.AppendText("No Printers found to print to.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection connection = null;
                foreach (DiscoveredPrinterDriver printer in UsbDiscoverer.GetZebraDriverPrinters())
                {
                    _Log.AppendText(printer.ToString());

                    if (connection == null)
                    {
                        connection = new DriverPrinterConnection(printer.ToString());
                        connection.MaxTimeoutForRead = 500;
                        connection.TimeToWaitForMoreData = 500;
                    }

                    try
                    {
                        if (!connection.Connected)
                            connection.Open();
                        ZebraPrinter prt = ZebraPrinterFactory.GetInstance(connection);

                        PrinterStatus printerStatus = prt.GetCurrentStatus();
                        if (printerStatus.isReadyToPrint)
                        {
                            _Log.AppendText("Ready To Print");
                        }
                        else if (printerStatus.isPaused)
                        {
                            _Log.AppendText("Cannot Print because the printer is paused.");
                        }
                        else if (printerStatus.isHeadOpen)
                        {
                            _Log.AppendText("Cannot Print because the printer head is open.");
                        }
                        else if (printerStatus.isPaperOut)
                        {
                            _Log.AppendText("Cannot Print because the paper is out.");
                        }
                        else
                        {
                            _Log.AppendText("Cannot Print.");
                        }

                    }
                    catch (ConnectionException ex)
                    {
                        _Log.AppendText(ex.ToString());
                    }
                    catch (ZebraPrinterLanguageUnknownException ex)
                    {
                        _Log.AppendText(ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }

                }

                //foreach (DiscoveredUsbPrinter usbPrinter in UsbDiscoverer.GetZebraUsbPrinters(new ZebraPrinterFilter()))
                //{
                //    _Log.AppendText(usbPrinter.ToString());
                //}
            }
            catch (ConnectionException ex)
            {
                _Log.AppendText($"Error discovering local printers: {ex.Message}");
            }

            _Log.AppendText("Done discovering local printers.");

        }

        private void timerPrinter_Tick(object sender, EventArgs e)
        {
            timerPrinter.Enabled = false;
            if (!Printing)
            {
                GetPrinterStatus();
                PostPrinterStatus();
            }
            timerPrinter.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //basicPrint("test");
            GetPrinterStatus();
        }


    } // frmMain

    public class HQES_Error_Flag
    {
        public bool PrinterNotFound { get; set; }
        public bool ReadFailed { get; set; }
        public bool Flag { get; set; }
        public String Nibbles16_9 { get; set; }
        public int Nibble8 { get; set; }
        public int Nibble7 { get; set; }
        public int Nibble6 { get; set; }
        public int Nibble5 { get; set; }
        public int Nibble4 { get; set; }
        public int Nibble3 { get; set; }
        public int Nibble2 { get; set; }
        public int Nibble1 { get; set; }

        public bool Printhead_Thermistor_Open { get { return (Nibble3 & 0x02) == 0x02; } }
        public bool Invalid_Firmware_Config { get { return (Nibble3 & 0x01) == 0x01; } }

        public bool Printhead_Detection_Error { get { return (Nibble2 & 0x08) == 0x08; } }
        public bool Bad_Printhead_Element { get { return (Nibble2 & 0x04) == 0x04; } }
        public bool Motor_Over_Temperature { get { return (Nibble2 & 0x02) == 0x02; } }
        public bool Printhead_Over_Temperature { get { return (Nibble2 & 0x01) == 0x01; } }

        public bool Cutter_Fault { get { return (Nibble1 & 0x08) == 0x08; } }
        public bool Head_Open { get { return (Nibble1 & 0x04) == 0x04; } }
        public bool Ribbon_Out { get { return (Nibble1 & 0x02) == 0x02; } }
        public bool Media_Out { get { return (Nibble1 & 0x01) == 0x01; } }

        public void Extract(String e)
        {
            string[] astr = e.Split(':');
            string data = astr[1].TrimStart();
            Flag = data[0] == '1';
            Nibbles16_9 = data.Substring(2, 8);
            Nibble8 = int.Parse(data[11].ToString());
            Nibble7 = int.Parse(data[12].ToString());
            Nibble6 = int.Parse(data[13].ToString());
            Nibble5 = int.Parse(data[14].ToString());
            Nibble4 = int.Parse(data[15].ToString());
            Nibble3 = int.Parse(data[16].ToString());
            Nibble2 = int.Parse(data[17].ToString());
            Nibble1 = int.Parse(data[18].ToString());
        }
    }

    public class HQES_Warning_Flag
    {
        public bool PrinterNotFound { get; set; }
        public bool ReadFailed { get; set; }
        public bool Flag { get; set; }
        public String Nibbles16_9 { get; set; }
        public int Nibble8 { get; set; }
        public int Nibble7 { get; set; }
        public int Nibble6 { get; set; }
        public int Nibble5 { get; set; }
        public int Nibble4 { get; set; }
        public int Nibble3 { get; set; }
        public int Nibble2 { get; set; }
        public int Nibble1 { get; set; }

        public bool Replace_Printhead { get { return (Nibble1 & 0x04) == 0x04; } }
        public bool Clean_Printhead { get { return (Nibble1 & 0x02) == 0x02; } }
        public bool Need_to_Calibrate_Media { get { return (Nibble1 & 0x01) == 0x01; } }

        public void Extract(String e)
        {
            string[] astr = e.Split(':');
            string data = astr[1].TrimStart();
            Flag = data[0] == '1';
            Nibbles16_9 = data.Substring(2, 8);
            Nibble8 = int.Parse(data[11].ToString());
            Nibble7 = int.Parse(data[12].ToString());
            Nibble6 = int.Parse(data[13].ToString());
            Nibble5 = int.Parse(data[14].ToString());
            Nibble4 = int.Parse(data[15].ToString());
            Nibble3 = int.Parse(data[16].ToString());
            Nibble2 = int.Parse(data[17].ToString());
            Nibble1 = int.Parse(data[18].ToString());
        }
    }
}
