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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
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
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrinter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(134, 282);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(204, 164);
            this.pictureBoxQRCode.TabIndex = 14;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 24);
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
            this.txtBoxQRCode.Location = new System.Drawing.Point(82, 230);
            this.txtBoxQRCode.Name = "txtBoxQRCode";
            this.txtBoxQRCode.Size = new System.Drawing.Size(421, 20);
            this.txtBoxQRCode.TabIndex = 18;
            this.txtBoxQRCode.Text = "1234567890";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(509, 228);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 23);
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
            this.chkPrinterNotFound.Location = new System.Drawing.Point(6, 54);
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
            this.chkPrinterError.Location = new System.Drawing.Point(6, 97);
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
            this.chkPrinterWarning.Location = new System.Drawing.Point(6, 140);
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
            this.chkPrinterHeadOpen.Location = new System.Drawing.Point(150, 97);
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
            this.chkPrinterReady.Location = new System.Drawing.Point(150, 54);
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
            // clock1
            // 
            this.clock1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.clock1.BeforeTouchSize = new System.Drawing.Size(75, 75);
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Analog;
            this.clock1.CurrentDateTime = new System.DateTime(2018, 12, 23, 1, 5, 27, 182);
            this.clock1.CustomTime = new System.DateTime(2018, 12, 23, 13, 0, 17, 985);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.Location = new System.Drawing.Point(655, 12);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2018, 12, 23, 1, 5, 27, 173);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(75, 75);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 26;
            this.clock1.Text = "clock1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrinter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkPrinterNotFound);
            this.groupBox1.Controls.Add(this.chkPrinterError);
            this.groupBox1.Controls.Add(this.chkPrinterReady);
            this.groupBox1.Controls.Add(this.chkPrinterWarning);
            this.groupBox1.Controls.Add(this.chkPrinterHeadOpen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 199);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRINTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PRINTER:";
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Location = new System.Drawing.Point(88, 28);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(19, 13);
            this.lblPrinter.TabIndex = 27;
            this.lblPrinter.Text = "...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clock1);
            this.Controls.Add(this.txtBoxQRCode);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Name = "frmMain";
            this.Text = "Serial To QR Code";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Label label1;
    }
}

