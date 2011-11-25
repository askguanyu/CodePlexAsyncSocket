namespace GY.NetAid.Controls
{
    partial class SendPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GY.NetAid.Controls.XMLViewerSettings xmlViewerSettings1 = new GY.NetAid.Controls.XMLViewerSettings();
            this.SendSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.WordWrapCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewXMLCheckBox = new System.Windows.Forms.CheckBox();
            this.HexCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoSendTimesTextBox = new System.Windows.Forms.TextBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.GUIDTextBox = new System.Windows.Forms.TextBox();
            this.PingButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XMLTextBox = new GY.NetAid.Controls.XMLViewer();
            this.SendSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendSettingsGroupBox
            // 
            this.SendSettingsGroupBox.Controls.Add(this.SendButton);
            this.SendSettingsGroupBox.Controls.Add(this.PingButton);
            this.SendSettingsGroupBox.Controls.Add(this.GUIDTextBox);
            this.SendSettingsGroupBox.Controls.Add(this.PortTextBox);
            this.SendSettingsGroupBox.Controls.Add(this.IPTextBox);
            this.SendSettingsGroupBox.Controls.Add(this.AutoSendTimesTextBox);
            this.SendSettingsGroupBox.Controls.Add(this.AutoSendCheckBox);
            this.SendSettingsGroupBox.Controls.Add(this.HexCheckBox);
            this.SendSettingsGroupBox.Controls.Add(this.ViewXMLCheckBox);
            this.SendSettingsGroupBox.Controls.Add(this.WordWrapCheckBox);
            this.SendSettingsGroupBox.Controls.Add(this.label4);
            this.SendSettingsGroupBox.Controls.Add(this.label3);
            this.SendSettingsGroupBox.Controls.Add(this.label2);
            this.SendSettingsGroupBox.Controls.Add(this.label1);
            this.SendSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendSettingsGroupBox.Location = new System.Drawing.Point(0, 220);
            this.SendSettingsGroupBox.Name = "SendSettingsGroupBox";
            this.SendSettingsGroupBox.Size = new System.Drawing.Size(480, 100);
            this.SendSettingsGroupBox.TabIndex = 1;
            this.SendSettingsGroupBox.TabStop = false;
            // 
            // WordWrapCheckBox
            // 
            this.WordWrapCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WordWrapCheckBox.AutoSize = true;
            this.WordWrapCheckBox.Location = new System.Drawing.Point(3, 10);
            this.WordWrapCheckBox.Name = "WordWrapCheckBox";
            this.WordWrapCheckBox.Size = new System.Drawing.Size(81, 17);
            this.WordWrapCheckBox.TabIndex = 0;
            this.WordWrapCheckBox.Text = "Word Wrap";
            this.WordWrapCheckBox.UseVisualStyleBackColor = true;
            this.WordWrapCheckBox.CheckedChanged += new System.EventHandler(this.WordWrapCheckBox_CheckedChanged);
            // 
            // ViewXMLCheckBox
            // 
            this.ViewXMLCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ViewXMLCheckBox.AutoSize = true;
            this.ViewXMLCheckBox.Location = new System.Drawing.Point(3, 33);
            this.ViewXMLCheckBox.Name = "ViewXMLCheckBox";
            this.ViewXMLCheckBox.Size = new System.Drawing.Size(88, 17);
            this.ViewXMLCheckBox.TabIndex = 1;
            this.ViewXMLCheckBox.Text = "View as XML";
            this.ViewXMLCheckBox.UseVisualStyleBackColor = true;
            this.ViewXMLCheckBox.CheckedChanged += new System.EventHandler(this.ViewXMLCheckBox_CheckedChanged);
            // 
            // HexCheckBox
            // 
            this.HexCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HexCheckBox.AutoSize = true;
            this.HexCheckBox.Location = new System.Drawing.Point(3, 56);
            this.HexCheckBox.Name = "HexCheckBox";
            this.HexCheckBox.Size = new System.Drawing.Size(75, 17);
            this.HexCheckBox.TabIndex = 2;
            this.HexCheckBox.Text = "Hex String";
            this.HexCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(3, 79);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(48, 17);
            this.AutoSendCheckBox.TabIndex = 3;
            this.AutoSendCheckBox.Text = "Auto";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            // 
            // AutoSendTimesTextBox
            // 
            this.AutoSendTimesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoSendTimesTextBox.Enabled = false;
            this.AutoSendTimesTextBox.Location = new System.Drawing.Point(44, 77);
            this.AutoSendTimesTextBox.Name = "AutoSendTimesTextBox";
            this.AutoSendTimesTextBox.Size = new System.Drawing.Size(60, 20);
            this.AutoSendTimesTextBox.TabIndex = 4;
            this.AutoSendTimesTextBox.Text = "1";
            this.AutoSendTimesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Location = new System.Drawing.Point(321, 31);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(156, 20);
            this.IPTextBox.TabIndex = 5;
            this.IPTextBox.Text = "127.0.0.1";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTextBox.Location = new System.Drawing.Point(321, 54);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(156, 20);
            this.PortTextBox.TabIndex = 6;
            this.PortTextBox.Text = "9999";
            // 
            // GUIDTextBox
            // 
            this.GUIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GUIDTextBox.Location = new System.Drawing.Point(321, 8);
            this.GUIDTextBox.Name = "GUIDTextBox";
            this.GUIDTextBox.Size = new System.Drawing.Size(156, 20);
            this.GUIDTextBox.TabIndex = 7;
            this.GUIDTextBox.WordWrap = false;
            // 
            // PingButton
            // 
            this.PingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PingButton.Location = new System.Drawing.Point(321, 75);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(75, 23);
            this.PingButton.TabIndex = 8;
            this.PingButton.Text = "Ping";
            this.PingButton.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(402, 75);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "GUID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "/Sec";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMLTextBox.Location = new System.Drawing.Point(0, 0);
            this.XMLTextBox.Name = "XMLTextBox";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.XMLTextBox.Settings = xmlViewerSettings1;
            this.XMLTextBox.Size = new System.Drawing.Size(480, 220);
            this.XMLTextBox.TabIndex = 0;
            this.XMLTextBox.Text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><html><head><title>My home page</title></h" +
    "ead><body bgcolor=\"000000\" text=\"ff0000\">Hello World!</body></html>\n";
            this.XMLTextBox.WordWrap = false;
            // 
            // SendPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.XMLTextBox);
            this.Controls.Add(this.SendSettingsGroupBox);
            this.Name = "SendPanel";
            this.Size = new System.Drawing.Size(480, 320);
            this.SendSettingsGroupBox.ResumeLayout(false);
            this.SendSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SendSettingsGroupBox;
        private System.Windows.Forms.CheckBox HexCheckBox;
        private System.Windows.Forms.CheckBox ViewXMLCheckBox;
        private System.Windows.Forms.CheckBox WordWrapCheckBox;
        private System.Windows.Forms.CheckBox AutoSendCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button SendButton;
        public System.Windows.Forms.Button PingButton;
        public System.Windows.Forms.TextBox GUIDTextBox;
        public System.Windows.Forms.TextBox PortTextBox;
        public System.Windows.Forms.TextBox IPTextBox;
        public System.Windows.Forms.TextBox AutoSendTimesTextBox;
        public XMLViewer XMLTextBox;
    }
}
