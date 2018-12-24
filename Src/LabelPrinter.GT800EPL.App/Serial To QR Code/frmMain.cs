using QRCoder;
using SerialText.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer.Discovery;

namespace Serial_To_QR_Code
{
    public partial class frmMain : Form
    {
        LogFile.Log _Log = new LogFile.Log(@"C:\Log", @"Qr Coder");
        volatile bool Printing = false;

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
        volatile bool IsPolling = false;

        HQES_Error_Flag error_Flag = new HQES_Error_Flag();
        HQES_Warning_Flag warning_Flag = new HQES_Warning_Flag();

        #region Delegate procedures

        private delegate void VoidDelegate();

        public void PostStatus(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new VoidDelegate(delegate ()
                {
                    try { lblStatus.Text = text; } catch { }
                }));
            }
            else
            {
                try { lblStatus.Text = text; } catch { }
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
            #region Printer not found
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
            #endregion
            #region Print ready
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
            #endregion
            #region Head open
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
            #endregion
            #region Printhead thermistor open
            if (chkPrinthead_Thermistor_Open.InvokeRequired)
            {
                chkPrinthead_Thermistor_Open.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Printhead_Thermistor_Open) chkPrinthead_Thermistor_Open.Checked = true;
                    else chkPrinthead_Thermistor_Open.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Printhead_Thermistor_Open) chkPrinthead_Thermistor_Open.Checked = true;
                else chkPrinthead_Thermistor_Open.Checked = false;
            }
            #endregion
            #region Invalid firmware config.
            if (chkInvalid_Firmware_Config.InvokeRequired)
            {
                chkInvalid_Firmware_Config.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Invalid_Firmware_Config) chkInvalid_Firmware_Config.Checked = true;
                    else chkInvalid_Firmware_Config.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Invalid_Firmware_Config) chkInvalid_Firmware_Config.Checked = true;
                else chkInvalid_Firmware_Config.Checked = false;
            }
            #endregion
            #region Printhead detection error
            if (chkPrinthead_Detection_Error.InvokeRequired)
            {
                chkPrinthead_Detection_Error.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Printhead_Detection_Error) chkPrinthead_Detection_Error.Checked = true;
                    else chkPrinthead_Detection_Error.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Printhead_Detection_Error) chkPrinthead_Detection_Error.Checked = true;
                else chkPrinthead_Detection_Error.Checked = false;
            }
            #endregion
            #region BAd printhead element
            if (chkBad_Printhead_Element.InvokeRequired)
            {
                chkBad_Printhead_Element.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Bad_Printhead_Element) chkBad_Printhead_Element.Checked = true;
                    else chkBad_Printhead_Element.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Bad_Printhead_Element) chkBad_Printhead_Element.Checked = true;
                else chkBad_Printhead_Element.Checked = false;
            }
            #endregion
            #region Motor over temperature
            if (chkMotor_Over_Temperature.InvokeRequired)
            {
                chkMotor_Over_Temperature.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Motor_Over_Temperature) chkMotor_Over_Temperature.Checked = true;
                    else chkMotor_Over_Temperature.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Motor_Over_Temperature) chkMotor_Over_Temperature.Checked = true;
                else chkMotor_Over_Temperature.Checked = false;
            }
            #endregion
            #region Printhead over temperature
            if (chkPrinthead_Over_Temperature.InvokeRequired)
            {
                chkPrinthead_Over_Temperature.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Printhead_Over_Temperature) chkPrinthead_Over_Temperature.Checked = true;
                    else chkPrinthead_Over_Temperature.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Printhead_Over_Temperature) chkPrinthead_Over_Temperature.Checked = true;
                else chkPrinthead_Over_Temperature.Checked = false;
            }
            #endregion
            #region Cutter fault
            if (chkCutter_Fault.InvokeRequired)
            {
                chkCutter_Fault.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Cutter_Fault) chkCutter_Fault.Checked = true;
                    else chkCutter_Fault.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Cutter_Fault) chkCutter_Fault.Checked = true;
                else chkCutter_Fault.Checked = false;
            }
            #endregion
            #region Ribbon out
            if (chkRibbon_Out.InvokeRequired)
            {
                chkRibbon_Out.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Ribbon_Out) chkRibbon_Out.Checked = true;
                    else chkRibbon_Out.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Ribbon_Out) chkRibbon_Out.Checked = true;
                else chkRibbon_Out.Checked = false;
            }
            #endregion
            #region Media out
            if (chkMedia_Out.InvokeRequired)
            {
                chkMedia_Out.Invoke(new VoidDelegate(delegate ()
                {
                    if (error_Flag.Media_Out) chkMedia_Out.Checked = true;
                    else chkMedia_Out.Checked = false;
                }));
            }
            else
            {
                if (error_Flag.Media_Out) chkMedia_Out.Checked = true;
                else chkMedia_Out.Checked = false;
            }
            #endregion
        }

        public void PostPortStatus()
        {
            #region Port not found
            if (chkSerialNotFound.InvokeRequired)
            {
                chkSerialNotFound.Invoke(new VoidDelegate(delegate ()
                {
                    if (serialText.PortNotFound) chkSerialNotFound.Checked = true;
                    else chkSerialNotFound.Checked = false;
                }));
            }
            else
            {
                if (serialText.PortNotFound) chkSerialNotFound.Checked = true;
                else chkSerialNotFound.Checked = false;
            }
            #endregion
            #region Port ready
            if (chkSerialReady.InvokeRequired)
            {
                chkSerialReady.Invoke(new VoidDelegate(delegate ()
                {
                    chkSerialReady.Checked = Running;
                }));
            }
            else
            {
                chkSerialReady.Checked = Running;
            }
            #endregion

        }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += FrmMain_FormClosing;
            this.Load += FrmMain_Load;
            this.btnPrint.Click += BtnPrint_Click;
            this.txtBoxQRCode.KeyPress += TxtBoxQRCode_KeyPress;

            txtLeft.KeyPress += Txt_KeyPress;
            txtTop.KeyPress += Txt_KeyPress;
            txtWidth.KeyPress += Txt_KeyPress;
            txtHeight.KeyPress += Txt_KeyPress;

            txtLeft.Leave += Txt_Leave;
            txtTop.Leave += Txt_Leave;
            txtWidth.Leave += Txt_Leave;
            txtHeight.Leave += Txt_Leave;

            cboPorts.KeyPress += Port_KeyPress;
            cboPorts.Leave += Port_Leave;

            btnStopSerialPolling.Click += BtnStopSerialPolling_Click;
            btnStartSerialPolling.Click += BtnStartSerialPolling_Click;

            timerPrinter.Interval = 1000;
            timerPrinter.Enabled = true;

            GetSerialPorts();
            DefineFixtureItems();

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = this.Text + " " + version;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnStartSerialPolling_Click(object sender, EventArgs e)
        {
            StartPolling();
        }

        private void BtnStopSerialPolling_Click(object sender, EventArgs e)
        {
            StopPolling();
            Thread.Sleep(1000);
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SaveSettings();
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SaveSettings();
                StopPolling();
                //Thread.Sleep(3000);
                StartPolling();
            }
        }

        private void Port_Leave(object sender, EventArgs e)
        {
            SaveSettings();
        }

        /// <summary>
        /// Generate qr code by key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxQRCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                RenderQrCode(txtBoxQRCode.Text);
        }

        /// <summary>
        /// Froce Print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print(txtBoxQRCode.Text);
        }

        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            StartPolling();
        }

        /// <summary>
        /// Form closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Do you want to exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                StopFlag = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Retrive port name from system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPorts_Click(object sender, EventArgs e)
        {
            GetSerialPorts();
        }

        /// <summary>
        /// Polling of a printer status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Save settings
        /// </summary>
        private void SaveSettings()
        {
            Properties.Settings.Default.PortName = cboPorts.Text;
            Properties.Settings.Default.FixtureLeft = txtLeft.Text;
            Properties.Settings.Default.CodeTop = txtTop.Text;
            Properties.Settings.Default.CodeWidth = txtWidth.Text;
            Properties.Settings.Default.CodeHeight = txtHeight.Text;

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();
        }

        /// <summary>
        /// Start thread of serial polling
        /// </summary>
        void StartPolling()
        {
            if (!IsPolling)
            {
                StopFlag = false;
                tPolling = new Thread(PollingLoop);
                tPolling.Start();
            }
        }

        /// <summary>
        /// Stop thread of serial polling
        /// </summary>
        public void StopPolling()
        {
            StopFlag = true;
            logText = "Stop Polling"; _Log.AppendText(logText);
        }

        /// <summary>
        /// Connect serial port by fixed port name
        /// </summary>
        void Connect()
        {
            Connecting = true;

            serialText.PortName = this.portName = Properties.Settings.Default.PortName;

            int Attemps = 10;

            for (int i = 0; i < Attemps; i++)
            {
                Response serial_res = serialText.Open();
                //logText = serial_res.Message; _Log.AppendText(logText);
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

        /// <summary>
        /// Reconnection thread
        /// </summary>
        void Reconnection()
        {
            while (!Running)
            {
                Connect();
                Thread.Sleep(100);
                if (StopFlag) return;
            }
        }

        /// <summary>
        /// MAIN SERIAL PORT POLLING
        /// </summary>
        void PollingLoop()
        {
            try
            {
                IsPolling = true;
                btnStartSerialPolling.Invoke(new VoidDelegate(delegate () { btnStartSerialPolling.Enabled = false; }));

                /* ----------------------------------------------------------------------------
                 * Start
                 * ----------------------------------------------------------------------------*/
                logText = "Start serial port polling."; _Log.AppendText(logText);
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
                    PostPortStatus();

                    if (Running && !Connecting)
                    {
                        //logText = "Do polling..."; _Log.AppendText(logText);

                        serial_res = serialText.Read();
                        logText = serial_res.Message;
                        //_Log.AppendText(logText);
                        if (!serial_res.Success)
                        {
                            if (serial_res.Code != 6 && serial_res.Code != 7)// 6= NoBytesToRead, 7 = LrcFailed
                            {
                                if (!StopFlag)
                                {
                                    Running = false;
                                    tRecon = new Thread(Reconnection); // Fast response() and wait for connection here!
                                    tRecon.Start();
                                    _Log.AppendText(logText);
                                }
                            }

                            if (serial_res.Code == 7) // LrcFailed
                            {
                                _Log.AppendText(logText);
                            }
                        }
                        else // Success
                        {
                            List<StringBuilder> ret = (List<StringBuilder>)serial_res.Data;
                            foreach (StringBuilder sb in ret)
                            {
                                string str = (sb.ToString().Replace(":", "")).Replace("#", "");

                                // -------------------------------------
                                // Interprete message
                                // -------------------------------------
                                switch (str.Substring(0, 2).ToUpper())
                                {
                                    case "QR":
                                        Printing = true;
                                        GenerateQrCode(str.Substring(2));
                                        logText = String.Format(">>> Qr Generated : {0}", str);
                                        _Log.AppendText(logText);
                                        PostStatus(logText);
                                        Print(str);
                                        Printing = false;
                                        break;
                                    default:
                                        this.chkSerialReadFault.Invoke(new VoidDelegate(delegate ()
                                        {
                                            if (!chkSerialReadFault.Checked)
                                            {
                                                chkSerialReadFault.Checked = true;
                                                Thread.Sleep(500);
                                                chkSerialReadFault.Checked = false;
                                            }
                                        }));
                                        break;
                                }

                            }
                        }

                        Thread.Sleep(PollingDelay);
                    }
                }

                /* ----------------------------------------------------------------------------
                 * Exit
                 * ----------------------------------------------------------------------------*/
                serialText.Close();
                logText = "End the process."; _Log.AppendText(logText); PostStatus(logText);
                btnStartSerialPolling.Invoke(new VoidDelegate(delegate () { try { btnStartSerialPolling.Enabled = true; } catch { } }));
                Running = false;
                IsPolling = false;
                PostPortStatus();
            }
            catch (Exception ex)
            {
                /* ----------------------------------------------------------------------------
                 * Log
                 * ----------------------------------------------------------------------------*/
                serialText.Close();
                logText = "Exceptional stop."; _Log.AppendText(logText);
                logText = ex.Message; _Log.AppendText(logText);
                PostStatus(logText);
                btnStartSerialPolling.Invoke(new VoidDelegate(delegate () { try { btnStartSerialPolling.Enabled = true; } catch { } }));
                Running = false;
                IsPolling = false;
                PostPortStatus();
            }
        }

        /// <summary>
        /// Draw and save qr code to a file
        /// </summary>
        /// <param name="e"></param>
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

        /// <summary>
        /// Format qr code and render
        /// </summary>
        /// <param name="text"></param>
        private void GenerateQrCode(string text)
        {
            string code = string.Format("{0}", text);
            this.Invoke(new Action(delegate () { txtBoxQRCode.Text = code; }));
            RenderQrCode(code);
        }

        /// <summary>
        /// Create print document, print and then send response via serial port
        /// </summary>
        /// <param name="e"></param>
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

        public List<DiscoveredPrinter> GetUSBPrinters()
        {
            List<DiscoveredPrinter> printerList = new List<DiscoveredPrinter>();
            try
            {
                foreach (DiscoveredUsbPrinter usbPrinter in UsbDiscoverer.GetZebraUsbPrinters())
                {
                    printerList.Add(usbPrinter);
                    //_Log.AppendText(usbPrinter.ToString());
                }
            }
            catch (ConnectionException e)
            {
                _Log.AppendText($"Error discovering local printers: {e.Message}");
                error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = true;
            }

            //_Log.AppendText("Done discovering local printers.");
            error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = false;
            return printerList;
        }

        public void basicPrint()
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
                    //_Log.AppendText(converted);
                    string status = string.Empty;
                    if (2 != buffer3[0])
                    {
                        //_Log.AppendText("Read in extra data from some other command!");
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

                    // Log
                    if (error_Flag.Flag || warning_Flag.Flag) _Log.AppendText(converted);
                }
            }
            else
            {
                error_Flag.PrinterNotFound = warning_Flag.PrinterNotFound = true;
                error_Flag.Flag = warning_Flag.Flag = true;
                PostPrinterName("-");
                _Log.AppendText("No Printers found to print to.");
            }
        }

        /// <summary>
        /// Create combo box of fixture
        /// </summary>
        private void DefineFixtureItems()
        {
            txtLeft.Text = Properties.Settings.Default.FixtureLeft;
            txtTop.Text = Properties.Settings.Default.CodeTop;
            txtWidth.Text = Properties.Settings.Default.CodeWidth;
            txtHeight.Text = Properties.Settings.Default.CodeHeight;
        }

        private void GetSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.Clear();
            for (int i = 0; i < ports.Length; i++) cboPorts.Items.Add(ports[i]);
            cboPorts.Text = Properties.Settings.Default.PortName;
        }

    } // frmMain

    #region Error flag class
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

    #endregion
}
