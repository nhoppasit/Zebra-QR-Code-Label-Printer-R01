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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_To_QR_Code
{
    public partial class frmMain : Form
    {
        private delegate void VoidDelegate();

        public void PostResponse(string text)
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

        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += FrmMain_FormClosing;
            this.Load += FrmMain_Load;
            this.btnPrint.Click += BtnPrint_Click;
            this.txtBoxQRCode.KeyPress += TxtBoxQRCode_KeyPress;

            this.WindowState = FormWindowState.Maximized;
        }

        private void TxtBoxQRCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                RenderQrCode(txtBoxQRCode.Text);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread t = new System.Threading.Thread(Loop);
            //t.Start();
            // Print();

            SlipPrinter.PrintProcess.Process(new string[] { txtBoxQRCode.Text, "", "", "", "" });
            try { serialText.Write("Printed.\r\n"); }
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
                        logText = "Do polling..."; _Log.AppendText(logText);

                        serial_res = serialText.Read();
                        logText = serial_res.Message;
                        _Log.AppendText(logText);
                        if (!serial_res.Success)
                        {
                            if (serial_res.Code != 6 && serial_res.Code != 7)
                            {
                                if (!StopFlag)
                                {
                                    Running = false;
                                    tRecon = new Thread(Reconnection); // Fast response() and wait for connection here!
                                    tRecon.Start();
                                }
                            }
                        }
                        else // Success
                        {
                            List<StringBuilder> ret = (List<StringBuilder>)serial_res.Data;
                            foreach (StringBuilder sb in ret)
                            {
                                string str = (sb.ToString().Replace(":", "")).Replace("#", "");
                                GenerateQrCode(str);
                                logText = String.Format(">>> Qr Generated : {0}", str);
                                _Log.AppendText(logText);
                                PostResponse(logText);
                            }
                        }

                        Thread.Sleep(PollingDelay);
                    }
                }

                /* ----------------------------------------------------------------------------
                 * Exit
                 * ----------------------------------------------------------------------------*/
                logText = "End the process."; _Log.AppendText(logText); PostResponse(logText);
            }
            catch (Exception ex)
            {
                /* ----------------------------------------------------------------------------
                 * Log
                 * ----------------------------------------------------------------------------*/
                logText = "Exceptional stop."; _Log.AppendText(logText);
                logText = ex.Message; _Log.AppendText(logText);
                PostResponse(logText);
            }
        }

        #endregion

    }
}
