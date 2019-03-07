namespace Serial_To_QR_Code
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBoxQRCode = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkPrinterNotFound = new System.Windows.Forms.CheckBox();
            this.chkPrinterError = new System.Windows.Forms.CheckBox();
            this.chkPrinterWarning = new System.Windows.Forms.CheckBox();
            this.chkPrinterHeadOpen = new System.Windows.Forms.CheckBox();
            this.chkPrinterReady = new System.Windows.Forms.CheckBox();
            this.timerPrinter = new System.Windows.Forms.Timer(this.components);
            this.lblPrinter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPrinthead_Thermistor_Open = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkInvalid_Firmware_Config = new System.Windows.Forms.CheckBox();
            this.chkPrinthead_Detection_Error = new System.Windows.Forms.CheckBox();
            this.chkBad_Printhead_Element = new System.Windows.Forms.CheckBox();
            this.chkMotor_Over_Temperature = new System.Windows.Forms.CheckBox();
            this.chkPrinthead_Over_Temperature = new System.Windows.Forms.CheckBox();
            this.chkCutter_Fault = new System.Windows.Forms.CheckBox();
            this.chkRibbon_Out = new System.Windows.Forms.CheckBox();
            this.chkMedia_Out = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkReplace_Printhead = new System.Windows.Forms.CheckBox();
            this.chkClean_Printhead = new System.Windows.Forms.CheckBox();
            this.chkNeed_to_Calibrate_Media = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chkSerialOpenFailed = new System.Windows.Forms.CheckBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStopSerialPolling = new System.Windows.Forms.Button();
            this.btnStartSerialPolling = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkQrCodePrinted = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetPorts = new System.Windows.Forms.Button();
            this.chkSerialReadFault = new System.Windows.Forms.CheckBox();
            this.chkPrinterStatus = new System.Windows.Forms.CheckBox();
            this.chkQrCode = new System.Windows.Forms.CheckBox();
            this.chkSerialNotFound = new System.Windows.Forms.CheckBox();
            this.chkSerialReady = new System.Windows.Forms.CheckBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(741, 600);
            this.pictureBoxQRCode.TabIndex = 14;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 828);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 24);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 19);
            this.lblStatus.Text = "...";
            // 
            // txtBoxQRCode
            // 
            this.txtBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBoxQRCode.Location = new System.Drawing.Point(10, 291);
            this.txtBoxQRCode.Name = "txtBoxQRCode";
            this.txtBoxQRCode.Size = new System.Drawing.Size(459, 31);
            this.txtBoxQRCode.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPrint.Location = new System.Drawing.Point(151, 378);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // chkPrinterNotFound
            // 
            this.chkPrinterNotFound.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterNotFound.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterNotFound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterNotFound.FlatAppearance.BorderSize = 2;
            this.chkPrinterNotFound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinterNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterNotFound.Location = new System.Drawing.Point(5, 39);
            this.chkPrinterNotFound.Name = "chkPrinterNotFound";
            this.chkPrinterNotFound.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterNotFound.TabIndex = 21;
            this.chkPrinterNotFound.Text = "NOT FOUND";
            this.chkPrinterNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterNotFound.UseCompatibleTextRendering = true;
            this.chkPrinterNotFound.UseVisualStyleBackColor = false;
            // 
            // chkPrinterError
            // 
            this.chkPrinterError.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterError.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterError.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterError.FlatAppearance.BorderSize = 2;
            this.chkPrinterError.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinterError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterError.Location = new System.Drawing.Point(3, 3);
            this.chkPrinterError.Name = "chkPrinterError";
            this.chkPrinterError.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterError.TabIndex = 22;
            this.chkPrinterError.Text = "ERROR";
            this.chkPrinterError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterError.UseCompatibleTextRendering = true;
            this.chkPrinterError.UseVisualStyleBackColor = false;
            // 
            // chkPrinterWarning
            // 
            this.chkPrinterWarning.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterWarning.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterWarning.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterWarning.FlatAppearance.BorderSize = 2;
            this.chkPrinterWarning.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinterWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterWarning.Location = new System.Drawing.Point(3, 3);
            this.chkPrinterWarning.Name = "chkPrinterWarning";
            this.chkPrinterWarning.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterWarning.TabIndex = 23;
            this.chkPrinterWarning.Text = "WARNING";
            this.chkPrinterWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterWarning.UseCompatibleTextRendering = true;
            this.chkPrinterWarning.UseVisualStyleBackColor = false;
            // 
            // chkPrinterHeadOpen
            // 
            this.chkPrinterHeadOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterHeadOpen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterHeadOpen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterHeadOpen.FlatAppearance.BorderSize = 2;
            this.chkPrinterHeadOpen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinterHeadOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterHeadOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterHeadOpen.Location = new System.Drawing.Point(147, 3);
            this.chkPrinterHeadOpen.Name = "chkPrinterHeadOpen";
            this.chkPrinterHeadOpen.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterHeadOpen.TabIndex = 24;
            this.chkPrinterHeadOpen.Text = "HEAD OPEN";
            this.chkPrinterHeadOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterHeadOpen.UseCompatibleTextRendering = true;
            this.chkPrinterHeadOpen.UseVisualStyleBackColor = false;
            // 
            // chkPrinterReady
            // 
            this.chkPrinterReady.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterReady.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterReady.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterReady.FlatAppearance.BorderSize = 2;
            this.chkPrinterReady.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkPrinterReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterReady.Location = new System.Drawing.Point(149, 39);
            this.chkPrinterReady.Name = "chkPrinterReady";
            this.chkPrinterReady.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterReady.TabIndex = 25;
            this.chkPrinterReady.Text = "READY";
            this.chkPrinterReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterReady.UseCompatibleTextRendering = true;
            this.chkPrinterReady.UseVisualStyleBackColor = false;
            // 
            // timerPrinter
            // 
            this.timerPrinter.Tick += new System.EventHandler(this.timerPrinter_Tick);
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPrinter.Location = new System.Drawing.Point(96, 13);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(19, 13);
            this.lblPrinter.TabIndex = 27;
            this.lblPrinter.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PRINTER:";
            // 
            // chkPrinthead_Thermistor_Open
            // 
            this.chkPrinthead_Thermistor_Open.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinthead_Thermistor_Open.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinthead_Thermistor_Open.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinthead_Thermistor_Open.FlatAppearance.BorderSize = 2;
            this.chkPrinthead_Thermistor_Open.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinthead_Thermistor_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinthead_Thermistor_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinthead_Thermistor_Open.Location = new System.Drawing.Point(291, 3);
            this.chkPrinthead_Thermistor_Open.Name = "chkPrinthead_Thermistor_Open";
            this.chkPrinthead_Thermistor_Open.Size = new System.Drawing.Size(138, 37);
            this.chkPrinthead_Thermistor_Open.TabIndex = 28;
            this.chkPrinthead_Thermistor_Open.Text = "PRINTEHEAD THERMISTOR OPEN";
            this.chkPrinthead_Thermistor_Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinthead_Thermistor_Open.UseCompatibleTextRendering = true;
            this.chkPrinthead_Thermistor_Open.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkPrinterError);
            this.flowLayoutPanel1.Controls.Add(this.chkPrinterHeadOpen);
            this.flowLayoutPanel1.Controls.Add(this.chkPrinthead_Thermistor_Open);
            this.flowLayoutPanel1.Controls.Add(this.chkInvalid_Firmware_Config);
            this.flowLayoutPanel1.Controls.Add(this.chkPrinthead_Detection_Error);
            this.flowLayoutPanel1.Controls.Add(this.chkBad_Printhead_Element);
            this.flowLayoutPanel1.Controls.Add(this.chkMotor_Over_Temperature);
            this.flowLayoutPanel1.Controls.Add(this.chkPrinthead_Over_Temperature);
            this.flowLayoutPanel1.Controls.Add(this.chkCutter_Fault);
            this.flowLayoutPanel1.Controls.Add(this.chkRibbon_Out);
            this.flowLayoutPanel1.Controls.Add(this.chkMedia_Out);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 127);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // chkInvalid_Firmware_Config
            // 
            this.chkInvalid_Firmware_Config.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInvalid_Firmware_Config.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkInvalid_Firmware_Config.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkInvalid_Firmware_Config.FlatAppearance.BorderSize = 2;
            this.chkInvalid_Firmware_Config.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkInvalid_Firmware_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInvalid_Firmware_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkInvalid_Firmware_Config.Location = new System.Drawing.Point(435, 3);
            this.chkInvalid_Firmware_Config.Name = "chkInvalid_Firmware_Config";
            this.chkInvalid_Firmware_Config.Size = new System.Drawing.Size(138, 37);
            this.chkInvalid_Firmware_Config.TabIndex = 29;
            this.chkInvalid_Firmware_Config.Text = "INVALID FIRMWARE CONFIG.";
            this.chkInvalid_Firmware_Config.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkInvalid_Firmware_Config.UseCompatibleTextRendering = true;
            this.chkInvalid_Firmware_Config.UseVisualStyleBackColor = false;
            // 
            // chkPrinthead_Detection_Error
            // 
            this.chkPrinthead_Detection_Error.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinthead_Detection_Error.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinthead_Detection_Error.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinthead_Detection_Error.FlatAppearance.BorderSize = 2;
            this.chkPrinthead_Detection_Error.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinthead_Detection_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinthead_Detection_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinthead_Detection_Error.Location = new System.Drawing.Point(3, 46);
            this.chkPrinthead_Detection_Error.Name = "chkPrinthead_Detection_Error";
            this.chkPrinthead_Detection_Error.Size = new System.Drawing.Size(138, 37);
            this.chkPrinthead_Detection_Error.TabIndex = 30;
            this.chkPrinthead_Detection_Error.Text = "PRINTHEAD DETECTION ERROR";
            this.chkPrinthead_Detection_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinthead_Detection_Error.UseCompatibleTextRendering = true;
            this.chkPrinthead_Detection_Error.UseVisualStyleBackColor = false;
            // 
            // chkBad_Printhead_Element
            // 
            this.chkBad_Printhead_Element.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBad_Printhead_Element.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkBad_Printhead_Element.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkBad_Printhead_Element.FlatAppearance.BorderSize = 2;
            this.chkBad_Printhead_Element.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkBad_Printhead_Element.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBad_Printhead_Element.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkBad_Printhead_Element.Location = new System.Drawing.Point(147, 46);
            this.chkBad_Printhead_Element.Name = "chkBad_Printhead_Element";
            this.chkBad_Printhead_Element.Size = new System.Drawing.Size(138, 37);
            this.chkBad_Printhead_Element.TabIndex = 31;
            this.chkBad_Printhead_Element.Text = "BAD PRINTHEAD ELEMENT";
            this.chkBad_Printhead_Element.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBad_Printhead_Element.UseCompatibleTextRendering = true;
            this.chkBad_Printhead_Element.UseVisualStyleBackColor = false;
            // 
            // chkMotor_Over_Temperature
            // 
            this.chkMotor_Over_Temperature.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMotor_Over_Temperature.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkMotor_Over_Temperature.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkMotor_Over_Temperature.FlatAppearance.BorderSize = 2;
            this.chkMotor_Over_Temperature.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkMotor_Over_Temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMotor_Over_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMotor_Over_Temperature.Location = new System.Drawing.Point(291, 46);
            this.chkMotor_Over_Temperature.Name = "chkMotor_Over_Temperature";
            this.chkMotor_Over_Temperature.Size = new System.Drawing.Size(138, 37);
            this.chkMotor_Over_Temperature.TabIndex = 32;
            this.chkMotor_Over_Temperature.Text = "MOTOR OVER TEMPERATURE";
            this.chkMotor_Over_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMotor_Over_Temperature.UseCompatibleTextRendering = true;
            this.chkMotor_Over_Temperature.UseVisualStyleBackColor = false;
            // 
            // chkPrinthead_Over_Temperature
            // 
            this.chkPrinthead_Over_Temperature.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinthead_Over_Temperature.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinthead_Over_Temperature.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinthead_Over_Temperature.FlatAppearance.BorderSize = 2;
            this.chkPrinthead_Over_Temperature.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkPrinthead_Over_Temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinthead_Over_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinthead_Over_Temperature.Location = new System.Drawing.Point(435, 46);
            this.chkPrinthead_Over_Temperature.Name = "chkPrinthead_Over_Temperature";
            this.chkPrinthead_Over_Temperature.Size = new System.Drawing.Size(138, 37);
            this.chkPrinthead_Over_Temperature.TabIndex = 33;
            this.chkPrinthead_Over_Temperature.Text = "PRINTHEAD OVER TEMPERATURE";
            this.chkPrinthead_Over_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinthead_Over_Temperature.UseCompatibleTextRendering = true;
            this.chkPrinthead_Over_Temperature.UseVisualStyleBackColor = false;
            // 
            // chkCutter_Fault
            // 
            this.chkCutter_Fault.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCutter_Fault.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkCutter_Fault.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkCutter_Fault.FlatAppearance.BorderSize = 2;
            this.chkCutter_Fault.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkCutter_Fault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCutter_Fault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkCutter_Fault.Location = new System.Drawing.Point(3, 89);
            this.chkCutter_Fault.Name = "chkCutter_Fault";
            this.chkCutter_Fault.Size = new System.Drawing.Size(138, 37);
            this.chkCutter_Fault.TabIndex = 34;
            this.chkCutter_Fault.Text = "CUTTER FAULT";
            this.chkCutter_Fault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCutter_Fault.UseCompatibleTextRendering = true;
            this.chkCutter_Fault.UseVisualStyleBackColor = false;
            // 
            // chkRibbon_Out
            // 
            this.chkRibbon_Out.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRibbon_Out.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkRibbon_Out.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkRibbon_Out.FlatAppearance.BorderSize = 2;
            this.chkRibbon_Out.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkRibbon_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRibbon_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkRibbon_Out.Location = new System.Drawing.Point(147, 89);
            this.chkRibbon_Out.Name = "chkRibbon_Out";
            this.chkRibbon_Out.Size = new System.Drawing.Size(138, 37);
            this.chkRibbon_Out.TabIndex = 35;
            this.chkRibbon_Out.Text = "RIBBON OUT";
            this.chkRibbon_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRibbon_Out.UseCompatibleTextRendering = true;
            this.chkRibbon_Out.UseVisualStyleBackColor = false;
            // 
            // chkMedia_Out
            // 
            this.chkMedia_Out.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMedia_Out.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkMedia_Out.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkMedia_Out.FlatAppearance.BorderSize = 2;
            this.chkMedia_Out.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkMedia_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMedia_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMedia_Out.Location = new System.Drawing.Point(291, 89);
            this.chkMedia_Out.Name = "chkMedia_Out";
            this.chkMedia_Out.Size = new System.Drawing.Size(138, 37);
            this.chkMedia_Out.TabIndex = 36;
            this.chkMedia_Out.Text = "MEDIA OUT";
            this.chkMedia_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMedia_Out.UseCompatibleTextRendering = true;
            this.chkMedia_Out.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chkPrinterWarning);
            this.flowLayoutPanel2.Controls.Add(this.chkReplace_Printhead);
            this.flowLayoutPanel2.Controls.Add(this.chkClean_Printhead);
            this.flowLayoutPanel2.Controls.Add(this.chkNeed_to_Calibrate_Media);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(613, 127);
            this.flowLayoutPanel2.TabIndex = 30;
            // 
            // chkReplace_Printhead
            // 
            this.chkReplace_Printhead.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkReplace_Printhead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkReplace_Printhead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkReplace_Printhead.FlatAppearance.BorderSize = 2;
            this.chkReplace_Printhead.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkReplace_Printhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReplace_Printhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkReplace_Printhead.Location = new System.Drawing.Point(147, 3);
            this.chkReplace_Printhead.Name = "chkReplace_Printhead";
            this.chkReplace_Printhead.Size = new System.Drawing.Size(138, 37);
            this.chkReplace_Printhead.TabIndex = 24;
            this.chkReplace_Printhead.Text = "REPLACE PRINTHEAD";
            this.chkReplace_Printhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkReplace_Printhead.UseCompatibleTextRendering = true;
            this.chkReplace_Printhead.UseVisualStyleBackColor = false;
            // 
            // chkClean_Printhead
            // 
            this.chkClean_Printhead.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkClean_Printhead.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkClean_Printhead.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkClean_Printhead.FlatAppearance.BorderSize = 2;
            this.chkClean_Printhead.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkClean_Printhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClean_Printhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkClean_Printhead.Location = new System.Drawing.Point(291, 3);
            this.chkClean_Printhead.Name = "chkClean_Printhead";
            this.chkClean_Printhead.Size = new System.Drawing.Size(138, 37);
            this.chkClean_Printhead.TabIndex = 25;
            this.chkClean_Printhead.Text = "CLEAN PRINTHEAD";
            this.chkClean_Printhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkClean_Printhead.UseCompatibleTextRendering = true;
            this.chkClean_Printhead.UseVisualStyleBackColor = false;
            // 
            // chkNeed_to_Calibrate_Media
            // 
            this.chkNeed_to_Calibrate_Media.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNeed_to_Calibrate_Media.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkNeed_to_Calibrate_Media.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkNeed_to_Calibrate_Media.FlatAppearance.BorderSize = 2;
            this.chkNeed_to_Calibrate_Media.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkNeed_to_Calibrate_Media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNeed_to_Calibrate_Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkNeed_to_Calibrate_Media.Location = new System.Drawing.Point(435, 3);
            this.chkNeed_to_Calibrate_Media.Name = "chkNeed_to_Calibrate_Media";
            this.chkNeed_to_Calibrate_Media.Size = new System.Drawing.Size(138, 37);
            this.chkNeed_to_Calibrate_Media.TabIndex = 26;
            this.chkNeed_to_Calibrate_Media.Text = "NEED TO CALIBRATE MEDIA";
            this.chkNeed_to_Calibrate_Media.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNeed_to_Calibrate_Media.UseCompatibleTextRendering = true;
            this.chkNeed_to_Calibrate_Media.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 82);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 131);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.TabIndex = 31;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.chkPrinterReady);
            this.splitContainer2.Panel1.Controls.Add(this.lblPrinter);
            this.splitContainer2.Panel1.Controls.Add(this.chkPrinterNotFound);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1237, 828);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 28;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBox2);
            this.splitContainer3.Panel1.Controls.Add(this.label13);
            this.splitContainer3.Panel1.Controls.Add(this.textBox1);
            this.splitContainer3.Panel1.Controls.Add(this.label12);
            this.splitContainer3.Panel1.Controls.Add(this.chkSerialOpenFailed);
            this.splitContainer3.Panel1.Controls.Add(this.txtHeight);
            this.splitContainer3.Panel1.Controls.Add(this.txtWidth);
            this.splitContainer3.Panel1.Controls.Add(this.txtTop);
            this.splitContainer3.Panel1.Controls.Add(this.txtLeft);
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.label9);
            this.splitContainer3.Panel1.Controls.Add(this.label8);
            this.splitContainer3.Panel1.Controls.Add(this.btnStopSerialPolling);
            this.splitContainer3.Panel1.Controls.Add(this.btnStartSerialPolling);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.txtBoxQRCode);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.chkQrCodePrinted);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.btnGetPorts);
            this.splitContainer3.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer3.Panel1.Controls.Add(this.chkSerialReadFault);
            this.splitContainer3.Panel1.Controls.Add(this.chkPrinterStatus);
            this.splitContainer3.Panel1.Controls.Add(this.chkQrCode);
            this.splitContainer3.Panel1.Controls.Add(this.chkSerialNotFound);
            this.splitContainer3.Panel1.Controls.Add(this.chkSerialReady);
            this.splitContainer3.Panel1.Controls.Add(this.cboPorts);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxQRCode);
            this.splitContainer3.Size = new System.Drawing.Size(1237, 604);
            this.splitContainer3.SplitterDistance = 488;
            this.splitContainer3.TabIndex = 0;
            // 
            // chkSerialOpenFailed
            // 
            this.chkSerialOpenFailed.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSerialOpenFailed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkSerialOpenFailed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSerialOpenFailed.FlatAppearance.BorderSize = 2;
            this.chkSerialOpenFailed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkSerialOpenFailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSerialOpenFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkSerialOpenFailed.Location = new System.Drawing.Point(154, 129);
            this.chkSerialOpenFailed.Name = "chkSerialOpenFailed";
            this.chkSerialOpenFailed.Size = new System.Drawing.Size(138, 37);
            this.chkSerialOpenFailed.TabIndex = 53;
            this.chkSerialOpenFailed.Text = "OPEN FAULT";
            this.chkSerialOpenFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSerialOpenFailed.UseCompatibleTextRendering = true;
            this.chkSerialOpenFailed.UseVisualStyleBackColor = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtHeight.Location = new System.Drawing.Point(153, 532);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(78, 31);
            this.txtHeight.TabIndex = 52;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtWidth.Location = new System.Drawing.Point(153, 495);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(78, 31);
            this.txtWidth.TabIndex = 51;
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTop.Location = new System.Drawing.Point(153, 458);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(78, 31);
            this.txtTop.TabIndex = 50;
            // 
            // txtLeft
            // 
            this.txtLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLeft.Location = new System.Drawing.Point(153, 421);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(78, 31);
            this.txtLeft.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(237, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(237, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(237, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(237, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "mm";
            // 
            // btnStopSerialPolling
            // 
            this.btnStopSerialPolling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStopSerialPolling.Location = new System.Drawing.Point(10, 86);
            this.btnStopSerialPolling.Name = "btnStopSerialPolling";
            this.btnStopSerialPolling.Size = new System.Drawing.Size(138, 37);
            this.btnStopSerialPolling.TabIndex = 2;
            this.btnStopSerialPolling.Text = "STOP";
            this.btnStopSerialPolling.UseVisualStyleBackColor = true;
            // 
            // btnStartSerialPolling
            // 
            this.btnStartSerialPolling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnStartSerialPolling.Location = new System.Drawing.Point(154, 86);
            this.btnStartSerialPolling.Name = "btnStartSerialPolling";
            this.btnStartSerialPolling.Size = new System.Drawing.Size(138, 37);
            this.btnStartSerialPolling.TabIndex = 3;
            this.btnStartSerialPolling.Text = "START";
            this.btnStartSerialPolling.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(89, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "HEIGHT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(94, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "WIDTH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(111, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "TOP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(106, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "LEFT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(11, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "QR CODE:";
            // 
            // chkQrCodePrinted
            // 
            this.chkQrCodePrinted.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkQrCodePrinted.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkQrCodePrinted.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkQrCodePrinted.FlatAppearance.BorderSize = 2;
            this.chkQrCodePrinted.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkQrCodePrinted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQrCodePrinted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkQrCodePrinted.Location = new System.Drawing.Point(9, 378);
            this.chkQrCodePrinted.Name = "chkQrCodePrinted";
            this.chkQrCodePrinted.Size = new System.Drawing.Size(138, 37);
            this.chkQrCodePrinted.TabIndex = 33;
            this.chkQrCodePrinted.Text = "PRINTED";
            this.chkQrCodePrinted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkQrCodePrinted.UseCompatibleTextRendering = true;
            this.chkQrCodePrinted.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "PC SERIAL PORT:";
            // 
            // btnGetPorts
            // 
            this.btnGetPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnGetPorts.Location = new System.Drawing.Point(154, 43);
            this.btnGetPorts.Name = "btnGetPorts";
            this.btnGetPorts.Size = new System.Drawing.Size(138, 37);
            this.btnGetPorts.TabIndex = 1;
            this.btnGetPorts.Text = "GET PORTS";
            this.btnGetPorts.UseVisualStyleBackColor = true;
            this.btnGetPorts.Click += new System.EventHandler(this.btnGetPorts_Click);
            // 
            // chkSerialReadFault
            // 
            this.chkSerialReadFault.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSerialReadFault.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkSerialReadFault.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSerialReadFault.FlatAppearance.BorderSize = 2;
            this.chkSerialReadFault.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkSerialReadFault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSerialReadFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkSerialReadFault.Location = new System.Drawing.Point(10, 172);
            this.chkSerialReadFault.Name = "chkSerialReadFault";
            this.chkSerialReadFault.Size = new System.Drawing.Size(138, 37);
            this.chkSerialReadFault.TabIndex = 8;
            this.chkSerialReadFault.Text = "READ FAULT";
            this.chkSerialReadFault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSerialReadFault.UseCompatibleTextRendering = true;
            this.chkSerialReadFault.UseVisualStyleBackColor = false;
            // 
            // chkPrinterStatus
            // 
            this.chkPrinterStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPrinterStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrinterStatus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkPrinterStatus.FlatAppearance.BorderSize = 2;
            this.chkPrinterStatus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkPrinterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPrinterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkPrinterStatus.Location = new System.Drawing.Point(298, 172);
            this.chkPrinterStatus.Name = "chkPrinterStatus";
            this.chkPrinterStatus.Size = new System.Drawing.Size(138, 37);
            this.chkPrinterStatus.TabIndex = 7;
            this.chkPrinterStatus.Text = "PRINTER STATUS";
            this.chkPrinterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrinterStatus.UseCompatibleTextRendering = true;
            this.chkPrinterStatus.UseVisualStyleBackColor = false;
            // 
            // chkQrCode
            // 
            this.chkQrCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkQrCode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkQrCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkQrCode.FlatAppearance.BorderSize = 2;
            this.chkQrCode.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkQrCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkQrCode.Location = new System.Drawing.Point(154, 172);
            this.chkQrCode.Name = "chkQrCode";
            this.chkQrCode.Size = new System.Drawing.Size(138, 37);
            this.chkQrCode.TabIndex = 6;
            this.chkQrCode.Text = "QR CODE";
            this.chkQrCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkQrCode.UseCompatibleTextRendering = true;
            this.chkQrCode.UseVisualStyleBackColor = false;
            // 
            // chkSerialNotFound
            // 
            this.chkSerialNotFound.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSerialNotFound.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkSerialNotFound.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSerialNotFound.FlatAppearance.BorderSize = 2;
            this.chkSerialNotFound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkSerialNotFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSerialNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkSerialNotFound.Location = new System.Drawing.Point(10, 129);
            this.chkSerialNotFound.Name = "chkSerialNotFound";
            this.chkSerialNotFound.Size = new System.Drawing.Size(138, 37);
            this.chkSerialNotFound.TabIndex = 4;
            this.chkSerialNotFound.Text = "NOT FOUND";
            this.chkSerialNotFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSerialNotFound.UseCompatibleTextRendering = true;
            this.chkSerialNotFound.UseVisualStyleBackColor = false;
            // 
            // chkSerialReady
            // 
            this.chkSerialReady.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSerialReady.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkSerialReady.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkSerialReady.FlatAppearance.BorderSize = 2;
            this.chkSerialReady.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkSerialReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSerialReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkSerialReady.Location = new System.Drawing.Point(298, 129);
            this.chkSerialReady.Name = "chkSerialReady";
            this.chkSerialReady.Size = new System.Drawing.Size(138, 37);
            this.chkSerialReady.TabIndex = 5;
            this.chkSerialReady.Text = "READY";
            this.chkSerialReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSerialReady.UseCompatibleTextRendering = true;
            this.chkSerialReady.UseVisualStyleBackColor = false;
            // 
            // cboPorts
            // 
            this.cboPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(10, 47);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(138, 28);
            this.cboPorts.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(10, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 31);
            this.textBox1.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(11, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "TOP TEXT:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox2.Location = new System.Drawing.Point(9, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(459, 31);
            this.textBox2.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(10, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "BOTTOM TEXT:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 852);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Serial To QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtBoxQRCode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkPrinterNotFound;
        private System.Windows.Forms.CheckBox chkPrinterError;
        private System.Windows.Forms.CheckBox chkPrinterWarning;
        private System.Windows.Forms.CheckBox chkPrinterHeadOpen;
        private System.Windows.Forms.CheckBox chkPrinterReady;
        private System.Windows.Forms.Timer timerPrinter;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPrinthead_Thermistor_Open;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkInvalid_Firmware_Config;
        private System.Windows.Forms.CheckBox chkPrinthead_Detection_Error;
        private System.Windows.Forms.CheckBox chkBad_Printhead_Element;
        private System.Windows.Forms.CheckBox chkMotor_Over_Temperature;
        private System.Windows.Forms.CheckBox chkPrinthead_Over_Temperature;
        private System.Windows.Forms.CheckBox chkCutter_Fault;
        private System.Windows.Forms.CheckBox chkRibbon_Out;
        private System.Windows.Forms.CheckBox chkMedia_Out;
        private System.Windows.Forms.CheckBox chkReplace_Printhead;
        private System.Windows.Forms.CheckBox chkClean_Printhead;
        private System.Windows.Forms.CheckBox chkNeed_to_Calibrate_Media;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.CheckBox chkSerialReadFault;
        private System.Windows.Forms.CheckBox chkPrinterStatus;
        private System.Windows.Forms.CheckBox chkQrCode;
        private System.Windows.Forms.CheckBox chkSerialNotFound;
        private System.Windows.Forms.CheckBox chkSerialReady;
        private System.Windows.Forms.Button btnGetPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkQrCodePrinted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStopSerialPolling;
        private System.Windows.Forms.Button btnStartSerialPolling;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.CheckBox chkSerialOpenFailed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
    }
}

