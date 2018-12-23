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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBoxQRCode.Size = new System.Drawing.Size(817, 476);
            this.pictureBoxQRCode.TabIndex = 14;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 661);
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
            this.txtBoxQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBoxQRCode.Location = new System.Drawing.Point(10, 248);
            this.txtBoxQRCode.Name = "txtBoxQRCode";
            this.txtBoxQRCode.Size = new System.Drawing.Size(383, 20);
            this.txtBoxQRCode.TabIndex = 18;
            this.txtBoxQRCode.Text = "1234567890";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(152, 274);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 37);
            this.btnPrint.TabIndex = 17;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 84);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(613, 84);
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
            this.splitContainer1.Size = new System.Drawing.Size(1230, 88);
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
            this.splitContainer2.Size = new System.Drawing.Size(1237, 661);
            this.splitContainer2.SplitterDistance = 177;
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
            this.splitContainer3.Panel1.Controls.Add(this.txtBoxQRCode);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox6);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            this.splitContainer3.Panel1.Controls.Add(this.btnPrint);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox5);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox4);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox3);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox2);
            this.splitContainer3.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxQRCode);
            this.splitContainer3.Size = new System.Drawing.Size(1237, 480);
            this.splitContainer3.SplitterDistance = 412;
            this.splitContainer3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox1.FlatAppearance.BorderSize = 2;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox1.Location = new System.Drawing.Point(154, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 37);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "READY";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseCompatibleTextRendering = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox2.FlatAppearance.BorderSize = 2;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox2.Location = new System.Drawing.Point(10, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 37);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "NOT FOUND";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseCompatibleTextRendering = true;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox3.FlatAppearance.BorderSize = 2;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox3.Location = new System.Drawing.Point(10, 129);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(138, 37);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "QR CODE";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseCompatibleTextRendering = true;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox4.FlatAppearance.BorderSize = 2;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox4.Location = new System.Drawing.Point(154, 129);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(138, 37);
            this.checkBox4.TabIndex = 29;
            this.checkBox4.Text = "PRINTER STATUS";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseCompatibleTextRendering = true;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox5.FlatAppearance.BorderSize = 2;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox5.Location = new System.Drawing.Point(10, 172);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(138, 37);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.Text = "READ FAULT";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseCompatibleTextRendering = true;
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(154, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "RECONNECT";
            this.button1.UseVisualStyleBackColor = true;
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
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBox6.FlatAppearance.BorderSize = 2;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.checkBox6.Location = new System.Drawing.Point(10, 274);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(138, 37);
            this.checkBox6.TabIndex = 33;
            this.checkBox6.Text = "PRINTED";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseCompatibleTextRendering = true;
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(11, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "QR CODE:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 685);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

