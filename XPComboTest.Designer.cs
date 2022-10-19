namespace XPComboTest
{
    partial class XPComboTest
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
            DarkUI.Controls.DarkGroupBox darkGroupBox7;
            DarkUI.Controls.DarkGroupBox darkGroupBox2;
            DarkUI.Controls.DarkGroupBox darkGroupBoxSettings;
            DarkUI.Controls.DarkGroupBox darkGroupBox1;
            this.darkComboBoxToCombo = new DarkUI.Controls.DarkComboBox();
            this.darkButton5 = new DarkUI.Controls.DarkButton();
            this.darkComboBoxSerialPort = new DarkUI.Controls.DarkComboBox();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkNumericUpDownDelay = new DarkUI.Controls.DarkNumericUpDown();
            this.darkCheckBoxDtrEnable = new DarkUI.Controls.DarkCheckBox();
            this.darkCheckBoxRtsEnable = new DarkUI.Controls.DarkCheckBox();
            this.darkCheckBoxCMDVER = new DarkUI.Controls.DarkCheckBox();
            this.darkCheckBoxCMDFUN = new DarkUI.Controls.DarkCheckBox();
            this.darkCheckBoxCMDCON = new DarkUI.Controls.DarkCheckBox();
            this.darkCheckBoxCMDRST = new DarkUI.Controls.DarkCheckBox();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.darkComboBoxBaudRate = new DarkUI.Controls.DarkComboBox();
            this.darkComboBoxStopBits = new DarkUI.Controls.DarkComboBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkComboBoxDataBits = new DarkUI.Controls.DarkComboBox();
            this.darkComboBoxHandShake = new DarkUI.Controls.DarkComboBox();
            this.darkComboBoxParity = new DarkUI.Controls.DarkComboBox();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkTextBoxFreeFormat = new DarkUI.Controls.DarkTextBox();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkButtonConnectToSerial = new DarkUI.Controls.DarkButton();
            this.darkGroupBoxSerial = new DarkUI.Controls.DarkGroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.darkButtonDisconnect = new DarkUI.Controls.DarkButton();
            this.darkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            darkGroupBox7 = new DarkUI.Controls.DarkGroupBox();
            darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            darkGroupBoxSettings = new DarkUI.Controls.DarkGroupBox();
            darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            darkGroupBox7.SuspendLayout();
            darkGroupBox2.SuspendLayout();
            darkGroupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDownDelay)).BeginInit();
            darkGroupBox1.SuspendLayout();
            this.darkGroupBoxSerial.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkGroupBox7
            // 
            darkGroupBox7.BorderColor = System.Drawing.Color.White;
            darkGroupBox7.Controls.Add(this.darkComboBoxToCombo);
            darkGroupBox7.Controls.Add(this.darkButton5);
            darkGroupBox7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            darkGroupBox7.Location = new System.Drawing.Point(6, 19);
            darkGroupBox7.Name = "darkGroupBox7";
            darkGroupBox7.Size = new System.Drawing.Size(218, 52);
            darkGroupBox7.TabIndex = 16;
            darkGroupBox7.TabStop = false;
            darkGroupBox7.Text = "To Combo 1 predefined";
            // 
            // darkComboBoxToCombo
            // 
            this.darkComboBoxToCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxToCombo.FormattingEnabled = true;
            this.darkComboBoxToCombo.Location = new System.Drawing.Point(6, 18);
            this.darkComboBoxToCombo.Name = "darkComboBoxToCombo";
            this.darkComboBoxToCombo.Size = new System.Drawing.Size(100, 21);
            this.darkComboBoxToCombo.TabIndex = 4;
            // 
            // darkButton5
            // 
            this.darkButton5.Location = new System.Drawing.Point(115, 19);
            this.darkButton5.Name = "darkButton5";
            this.darkButton5.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton5.Size = new System.Drawing.Size(75, 20);
            this.darkButton5.TabIndex = 15;
            this.darkButton5.Text = "Send";
            this.darkButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.darkButton5.Click += new System.EventHandler(this.darkButton5_Click);
            // 
            // darkGroupBox2
            // 
            darkGroupBox2.BorderColor = System.Drawing.Color.White;
            darkGroupBox2.Controls.Add(this.darkComboBoxSerialPort);
            darkGroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            darkGroupBox2.Location = new System.Drawing.Point(2, 12);
            darkGroupBox2.Name = "darkGroupBox2";
            darkGroupBox2.Size = new System.Drawing.Size(118, 52);
            darkGroupBox2.TabIndex = 18;
            darkGroupBox2.TabStop = false;
            darkGroupBox2.Text = "Serial Port";
            // 
            // darkComboBoxSerialPort
            // 
            this.darkComboBoxSerialPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxSerialPort.FormattingEnabled = true;
            this.darkComboBoxSerialPort.Location = new System.Drawing.Point(6, 20);
            this.darkComboBoxSerialPort.Name = "darkComboBoxSerialPort";
            this.darkComboBoxSerialPort.Size = new System.Drawing.Size(100, 21);
            this.darkComboBoxSerialPort.TabIndex = 2;
            this.darkComboBoxSerialPort.SelectedIndexChanged += new System.EventHandler(this.darkComboBoxSerialPort_SelectedIndexChanged);
            // 
            // darkGroupBoxSettings
            // 
            darkGroupBoxSettings.BorderColor = System.Drawing.Color.Yellow;
            darkGroupBoxSettings.Controls.Add(this.darkLabel6);
            darkGroupBoxSettings.Controls.Add(this.darkNumericUpDownDelay);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxDtrEnable);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxRtsEnable);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxCMDVER);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxCMDFUN);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxCMDCON);
            darkGroupBoxSettings.Controls.Add(this.darkCheckBoxCMDRST);
            darkGroupBoxSettings.Controls.Add(this.darkLabel5);
            darkGroupBoxSettings.Controls.Add(this.darkComboBoxBaudRate);
            darkGroupBoxSettings.Controls.Add(this.darkComboBoxStopBits);
            darkGroupBoxSettings.Controls.Add(this.darkLabel1);
            darkGroupBoxSettings.Controls.Add(this.darkLabel4);
            darkGroupBoxSettings.Controls.Add(this.darkLabel2);
            darkGroupBoxSettings.Controls.Add(this.darkComboBoxDataBits);
            darkGroupBoxSettings.Controls.Add(this.darkComboBoxHandShake);
            darkGroupBoxSettings.Controls.Add(this.darkComboBoxParity);
            darkGroupBoxSettings.Controls.Add(this.darkLabel3);
            darkGroupBoxSettings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            darkGroupBoxSettings.Location = new System.Drawing.Point(2, 100);
            darkGroupBoxSettings.Name = "darkGroupBoxSettings";
            darkGroupBoxSettings.Size = new System.Drawing.Size(245, 358);
            darkGroupBoxSettings.TabIndex = 21;
            darkGroupBoxSettings.TabStop = false;
            darkGroupBoxSettings.Text = "Comm Settings";
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(12, 223);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(32, 13);
            this.darkLabel6.TabIndex = 35;
            this.darkLabel6.Text = "delay";
            // 
            // darkNumericUpDownDelay
            // 
            this.darkNumericUpDownDelay.Location = new System.Drawing.Point(75, 223);
            this.darkNumericUpDownDelay.Name = "darkNumericUpDownDelay";
            this.darkNumericUpDownDelay.Size = new System.Drawing.Size(51, 20);
            this.darkNumericUpDownDelay.TabIndex = 34;
            this.darkNumericUpDownDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // darkCheckBoxDtrEnable
            // 
            this.darkCheckBoxDtrEnable.AutoSize = true;
            this.darkCheckBoxDtrEnable.Checked = true;
            this.darkCheckBoxDtrEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkCheckBoxDtrEnable.Location = new System.Drawing.Point(74, 179);
            this.darkCheckBoxDtrEnable.Name = "darkCheckBoxDtrEnable";
            this.darkCheckBoxDtrEnable.Size = new System.Drawing.Size(73, 17);
            this.darkCheckBoxDtrEnable.TabIndex = 33;
            this.darkCheckBoxDtrEnable.Text = "DtrEnable";
            this.darkCheckBoxDtrEnable.UseMnemonic = false;
            // 
            // darkCheckBoxRtsEnable
            // 
            this.darkCheckBoxRtsEnable.AutoSize = true;
            this.darkCheckBoxRtsEnable.Checked = true;
            this.darkCheckBoxRtsEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkCheckBoxRtsEnable.Location = new System.Drawing.Point(75, 156);
            this.darkCheckBoxRtsEnable.Name = "darkCheckBoxRtsEnable";
            this.darkCheckBoxRtsEnable.Size = new System.Drawing.Size(75, 17);
            this.darkCheckBoxRtsEnable.TabIndex = 32;
            this.darkCheckBoxRtsEnable.Text = "RtsEnable";
            this.darkCheckBoxRtsEnable.UseMnemonic = false;
            // 
            // darkCheckBoxCMDVER
            // 
            this.darkCheckBoxCMDVER.AutoSize = true;
            this.darkCheckBoxCMDVER.Location = new System.Drawing.Point(74, 325);
            this.darkCheckBoxCMDVER.Name = "darkCheckBoxCMDVER";
            this.darkCheckBoxCMDVER.Size = new System.Drawing.Size(98, 17);
            this.darkCheckBoxCMDVER.TabIndex = 31;
            this.darkCheckBoxCMDVER.Text = "send CMDVER";
            this.darkCheckBoxCMDVER.UseMnemonic = false;
            // 
            // darkCheckBoxCMDFUN
            // 
            this.darkCheckBoxCMDFUN.AutoSize = true;
            this.darkCheckBoxCMDFUN.Location = new System.Drawing.Point(74, 302);
            this.darkCheckBoxCMDFUN.Name = "darkCheckBoxCMDFUN";
            this.darkCheckBoxCMDFUN.Size = new System.Drawing.Size(98, 17);
            this.darkCheckBoxCMDFUN.TabIndex = 30;
            this.darkCheckBoxCMDFUN.Text = "send CMDFUN";
            this.darkCheckBoxCMDFUN.UseMnemonic = false;
            // 
            // darkCheckBoxCMDCON
            // 
            this.darkCheckBoxCMDCON.AutoSize = true;
            this.darkCheckBoxCMDCON.Checked = true;
            this.darkCheckBoxCMDCON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkCheckBoxCMDCON.Location = new System.Drawing.Point(73, 279);
            this.darkCheckBoxCMDCON.Name = "darkCheckBoxCMDCON";
            this.darkCheckBoxCMDCON.Size = new System.Drawing.Size(99, 17);
            this.darkCheckBoxCMDCON.TabIndex = 29;
            this.darkCheckBoxCMDCON.Text = "send CMDCON";
            this.darkCheckBoxCMDCON.UseMnemonic = false;
            // 
            // darkCheckBoxCMDRST
            // 
            this.darkCheckBoxCMDRST.AutoSize = true;
            this.darkCheckBoxCMDRST.Location = new System.Drawing.Point(73, 256);
            this.darkCheckBoxCMDRST.Name = "darkCheckBoxCMDRST";
            this.darkCheckBoxCMDRST.Size = new System.Drawing.Size(98, 17);
            this.darkCheckBoxCMDRST.TabIndex = 28;
            this.darkCheckBoxCMDRST.Text = "send CMDRST";
            this.darkCheckBoxCMDRST.UseMnemonic = false;
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(6, 132);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(38, 13);
            this.darkLabel5.TabIndex = 27;
            this.darkLabel5.Text = "stopbit";
            // 
            // darkComboBoxBaudRate
            // 
            this.darkComboBoxBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxBaudRate.FormattingEnabled = true;
            this.darkComboBoxBaudRate.Location = new System.Drawing.Point(74, 19);
            this.darkComboBoxBaudRate.Name = "darkComboBoxBaudRate";
            this.darkComboBoxBaudRate.Size = new System.Drawing.Size(106, 21);
            this.darkComboBoxBaudRate.TabIndex = 3;
            // 
            // darkComboBoxStopBits
            // 
            this.darkComboBoxStopBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxStopBits.FormattingEnabled = true;
            this.darkComboBoxStopBits.Location = new System.Drawing.Point(74, 129);
            this.darkComboBoxStopBits.Name = "darkComboBoxStopBits";
            this.darkComboBoxStopBits.Size = new System.Drawing.Size(32, 21);
            this.darkComboBoxStopBits.TabIndex = 26;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(6, 22);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(49, 13);
            this.darkLabel1.TabIndex = 22;
            this.darkLabel1.Text = "baudrate";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(6, 105);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(44, 13);
            this.darkLabel4.TabIndex = 25;
            this.darkLabel4.Text = "databits";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(6, 49);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(60, 13);
            this.darkLabel2.TabIndex = 23;
            this.darkLabel2.Text = "handshake";
            // 
            // darkComboBoxDataBits
            // 
            this.darkComboBoxDataBits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxDataBits.FormattingEnabled = true;
            this.darkComboBoxDataBits.Location = new System.Drawing.Point(74, 102);
            this.darkComboBoxDataBits.Name = "darkComboBoxDataBits";
            this.darkComboBoxDataBits.Size = new System.Drawing.Size(32, 21);
            this.darkComboBoxDataBits.TabIndex = 2;
            // 
            // darkComboBoxHandShake
            // 
            this.darkComboBoxHandShake.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxHandShake.FormattingEnabled = true;
            this.darkComboBoxHandShake.Location = new System.Drawing.Point(74, 46);
            this.darkComboBoxHandShake.Name = "darkComboBoxHandShake";
            this.darkComboBoxHandShake.Size = new System.Drawing.Size(159, 21);
            this.darkComboBoxHandShake.TabIndex = 2;
            // 
            // darkComboBoxParity
            // 
            this.darkComboBoxParity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBoxParity.FormattingEnabled = true;
            this.darkComboBoxParity.Location = new System.Drawing.Point(74, 75);
            this.darkComboBoxParity.Name = "darkComboBoxParity";
            this.darkComboBoxParity.Size = new System.Drawing.Size(159, 21);
            this.darkComboBoxParity.TabIndex = 2;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(6, 83);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(32, 13);
            this.darkLabel3.TabIndex = 24;
            this.darkLabel3.Text = "parity";
            // 
            // darkGroupBox1
            // 
            darkGroupBox1.BorderColor = System.Drawing.Color.White;
            darkGroupBox1.Controls.Add(this.darkTextBoxFreeFormat);
            darkGroupBox1.Controls.Add(this.darkButton2);
            darkGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            darkGroupBox1.Location = new System.Drawing.Point(238, 19);
            darkGroupBox1.Name = "darkGroupBox1";
            darkGroupBox1.Size = new System.Drawing.Size(218, 52);
            darkGroupBox1.TabIndex = 17;
            darkGroupBox1.TabStop = false;
            darkGroupBox1.Text = "To Combo Free format";
            // 
            // darkTextBoxFreeFormat
            // 
            this.darkTextBoxFreeFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBoxFreeFormat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBoxFreeFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBoxFreeFormat.Location = new System.Drawing.Point(7, 21);
            this.darkTextBoxFreeFormat.MaxLength = 8;
            this.darkTextBoxFreeFormat.Name = "darkTextBoxFreeFormat";
            this.darkTextBoxFreeFormat.Size = new System.Drawing.Size(100, 20);
            this.darkTextBoxFreeFormat.TabIndex = 16;
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(115, 19);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 20);
            this.darkButton2.TabIndex = 15;
            this.darkButton2.Text = "Send";
            this.darkButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // darkButtonConnectToSerial
            // 
            this.darkButtonConnectToSerial.Enabled = false;
            this.darkButtonConnectToSerial.Location = new System.Drawing.Point(126, 12);
            this.darkButtonConnectToSerial.Name = "darkButtonConnectToSerial";
            this.darkButtonConnectToSerial.Padding = new System.Windows.Forms.Padding(5);
            this.darkButtonConnectToSerial.Size = new System.Drawing.Size(75, 20);
            this.darkButtonConnectToSerial.TabIndex = 6;
            this.darkButtonConnectToSerial.Text = "Connect";
            this.darkButtonConnectToSerial.Click += new System.EventHandler(this.darkButtonConnectToSerial_Click);
            // 
            // darkGroupBoxSerial
            // 
            this.darkGroupBoxSerial.BorderColor = System.Drawing.Color.Lime;
            this.darkGroupBoxSerial.Controls.Add(darkGroupBox1);
            this.darkGroupBoxSerial.Controls.Add(darkGroupBox7);
            this.darkGroupBoxSerial.Location = new System.Drawing.Point(253, 12);
            this.darkGroupBoxSerial.Name = "darkGroupBoxSerial";
            this.darkGroupBoxSerial.Size = new System.Drawing.Size(468, 82);
            this.darkGroupBoxSerial.TabIndex = 14;
            this.darkGroupBoxSerial.TabStop = false;
            this.darkGroupBoxSerial.Text = "Serial Connection";
            // 
            // darkButtonDisconnect
            // 
            this.darkButtonDisconnect.Enabled = false;
            this.darkButtonDisconnect.Location = new System.Drawing.Point(126, 44);
            this.darkButtonDisconnect.Name = "darkButtonDisconnect";
            this.darkButtonDisconnect.Padding = new System.Windows.Forms.Padding(5);
            this.darkButtonDisconnect.Size = new System.Drawing.Size(75, 20);
            this.darkButtonDisconnect.TabIndex = 22;
            this.darkButtonDisconnect.Text = "Disconnect";
            this.darkButtonDisconnect.Click += new System.EventHandler(this.darkButtonDisconnect_Click);
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.BorderColor = System.Drawing.Color.Magenta;
            this.darkGroupBox3.Controls.Add(this.richTextBoxLog);
            this.darkGroupBox3.Location = new System.Drawing.Point(253, 100);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(468, 358);
            this.darkGroupBox3.TabIndex = 15;
            this.darkGroupBox3.TabStop = false;
            this.darkGroupBox3.Text = "Logging";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxLog.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBoxLog.ShowSelectionMargin = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(440, 333);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(646, 464);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(75, 23);
            this.darkButton3.TabIndex = 23;
            this.darkButton3.Text = "Save Log";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // darkButton1
            // 
            this.darkButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.darkButton1.Location = new System.Drawing.Point(559, 464);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(75, 23);
            this.darkButton1.TabIndex = 24;
            this.darkButton1.Text = "Clear Log";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // XPComboTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(725, 490);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkButton3);
            this.Controls.Add(this.darkGroupBox3);
            this.Controls.Add(this.darkButtonDisconnect);
            this.Controls.Add(darkGroupBoxSettings);
            this.Controls.Add(darkGroupBox2);
            this.Controls.Add(this.darkGroupBoxSerial);
            this.Controls.Add(this.darkButtonConnectToSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XPComboTest";
            this.Text = "XPComboTest by xprezzo-marco";
            darkGroupBox7.ResumeLayout(false);
            darkGroupBox2.ResumeLayout(false);
            darkGroupBoxSettings.ResumeLayout(false);
            darkGroupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkNumericUpDownDelay)).EndInit();
            darkGroupBox1.ResumeLayout(false);
            darkGroupBox1.PerformLayout();
            this.darkGroupBoxSerial.ResumeLayout(false);
            this.darkGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkComboBox darkComboBoxSerialPort;
        private DarkUI.Controls.DarkButton darkButtonConnectToSerial;
        private DarkUI.Controls.DarkGroupBox darkGroupBoxSerial;
        
        private DarkUI.Controls.DarkButton darkButton5;
        private System.IO.Ports.SerialPort serialPort1;
        private DarkUI.Controls.DarkComboBox darkComboBoxHandShake;
        private DarkUI.Controls.DarkComboBox darkComboBoxParity;
        private DarkUI.Controls.DarkComboBox darkComboBoxDataBits;
        private DarkUI.Controls.DarkComboBox darkComboBoxBaudRate;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkComboBox darkComboBoxStopBits;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkButton darkButtonDisconnect;
        private DarkUI.Controls.DarkGroupBox darkGroupBox3;
        
        private DarkUI.Controls.DarkCheckBox darkCheckBoxCMDCON;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxCMDRST;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxCMDVER;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxCMDFUN;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxRtsEnable;
        private DarkUI.Controls.DarkCheckBox darkCheckBoxDtrEnable;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkNumericUpDown darkNumericUpDownDelay;
        private DarkUI.Controls.DarkComboBox darkComboBoxToCombo;
        private DarkUI.Controls.DarkTextBox darkTextBoxFreeFormat;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton3;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.Timer timer1;
    }
}

