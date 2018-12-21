using Microsoft.Win32.SafeHandles;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialText.Utilities;

namespace LabelPrinter.GT800EPL.Test01App
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

        LogFile.Log _Log = new LogFile.Log(@"C:\Log", @"Qr Coder");

        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
            this.txtBoxQRCode.KeyPress += TxtBoxQRCode_KeyPress;
            this.btnPrint.Click += BtnPrint_Click;

            serialText = new SerialText.SimpleSerialText(portName, baudRate, dataBits, parity, stopBits, handshake);//NodesNetwork(portName, baudRate, dataBits, parity, stopBits, handshake);
        }

        bool _StopFlag = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _StopFlag = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread t = new System.Threading.Thread(Loop);
            //t.Start();
            // Print();

            SlipPrinter.PrintProcess.Process(new string[] { txtBoxQRCode.Text, "", "", "", "" });
        }

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
                                string file = string.Format(@"C:\QR\{0}.jpg", txtBoxQRCode.Text);
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
                                // Do nothing : clising form
                            }
                        }));
                    }
                }
            }
        }
        
        private void TxtBoxQRCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
                RenderQrCode(txtBoxQRCode.Text);
        }
        
        #region SERIAL INTERFACE & POLLING

        string portName = string.Empty;
        int baudRate = 9600;
        int dataBits = 8;
        Parity parity = Parity.None;
        StopBits stopBits = StopBits.One;
        Handshake handshake = Handshake.None;

        int PollingDelay = 1000;
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

        void ReconnectionTimer_Tick(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(System.Windows.Forms.Timer))
            {
                System.Windows.Forms.Timer t = (System.Windows.Forms.Timer)sender;
                t.Enabled = false;
            }
        }

        void Connect()
        {
            Connecting = true;

            System.Windows.Forms.Timer ReconnectionTimer = new System.Windows.Forms.Timer();
            ReconnectionTimer.Tick += ReconnectionTimer_Tick;
            ReconnectionTimer.Interval = 300;
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

                ReconnectionTimer.Start();
                while (ReconnectionTimer.Enabled)
                {
                    if (StopFlag)
                    {
                        Connecting = false;
                        return;
                    }
                    Thread.Sleep(1);
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

        long id;
        private void GenerateQrCode()
        {
            for (int i = 1; i <= 1000; i++)
            {
                id = i % 100000;
                string text = string.Format("www.backtohome.org/thaimissing/hpm.php?sn=797{0:X5}", id);
                this.Invoke(new Action(delegate () { txtBoxQRCode.Text = text; }));
                RenderQrCode(text);
                //System.Threading.Thread.Sleep(1);
                if (_StopFlag) break;
            }
            //System.Threading.Thread.Sleep(200);
            MessageBox.Show("DONE.");
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
                        logText = serial_res.Message; _Log.AppendText(logText);
                        if (!serial_res.Success)
                        {
                            if (!StopFlag)
                            {
                                Running = false;
                                tRecon = new Thread(Reconnection); // Fast response() and wait for connection here!
                                tRecon.Start();
                            }
                        }
                        else // Success
                        {
                            GenerateQrCode();
                            logText = String.Format(">>> Qr Generated : {0}", ((StringBuilder)serial_res.Data).ToString()); _Log.AppendText(logText); PostResponse(logText);
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
                logText = ex.Message; _Log.AppendText(logText); PostResponse(logText);
            }
        }

        #endregion
    }
}
