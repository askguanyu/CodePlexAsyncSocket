namespace GY.NetAid.Controls
{
    partial class LogPanel
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
            this.LogPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.SplitContainerLogPanel = new System.Windows.Forms.SplitContainer();
            this.LogPanelTabControl = new System.Windows.Forms.TabControl();
            this.LogGeneralPage = new System.Windows.Forms.TabPage();
            this.ReceivedPage = new System.Windows.Forms.TabPage();
            this.SentPage = new System.Windows.Forms.TabPage();
            this.LogDetailSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewXMLCheckBox = new System.Windows.Forms.CheckBox();
            this.WordWrapCheckBox = new System.Windows.Forms.CheckBox();
            this.XMLTextBox = new GY.NetAid.Controls.XMLViewer();
            this.LogDetailTabControl = new System.Windows.Forms.TabControl();
            this.LogDetailTabPage = new System.Windows.Forms.TabPage();
            this.LogPanelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerLogPanel)).BeginInit();
            this.SplitContainerLogPanel.Panel1.SuspendLayout();
            this.SplitContainerLogPanel.Panel2.SuspendLayout();
            this.SplitContainerLogPanel.SuspendLayout();
            this.LogPanelTabControl.SuspendLayout();
            this.LogDetailSettingsGroupBox.SuspendLayout();
            this.LogDetailTabControl.SuspendLayout();
            this.LogDetailTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogPanelGroupBox
            // 
            this.LogPanelGroupBox.Controls.Add(this.SplitContainerLogPanel);
            this.LogPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanelGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LogPanelGroupBox.Name = "LogPanelGroupBox";
            this.LogPanelGroupBox.Size = new System.Drawing.Size(320, 480);
            this.LogPanelGroupBox.TabIndex = 1;
            this.LogPanelGroupBox.TabStop = false;
            this.LogPanelGroupBox.Text = "Log Info";
            // 
            // SplitContainerLogPanel
            // 
            this.SplitContainerLogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerLogPanel.Location = new System.Drawing.Point(3, 16);
            this.SplitContainerLogPanel.Name = "SplitContainerLogPanel";
            this.SplitContainerLogPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainerLogPanel.Panel1
            // 
            this.SplitContainerLogPanel.Panel1.Controls.Add(this.LogPanelTabControl);
            // 
            // SplitContainerLogPanel.Panel2
            // 
            this.SplitContainerLogPanel.Panel2.Controls.Add(this.LogDetailTabControl);
            this.SplitContainerLogPanel.Size = new System.Drawing.Size(314, 461);
            this.SplitContainerLogPanel.SplitterDistance = 139;
            this.SplitContainerLogPanel.TabIndex = 0;
            // 
            // LogPanelTabControl
            // 
            this.LogPanelTabControl.Controls.Add(this.LogGeneralPage);
            this.LogPanelTabControl.Controls.Add(this.ReceivedPage);
            this.LogPanelTabControl.Controls.Add(this.SentPage);
            this.LogPanelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanelTabControl.ItemSize = new System.Drawing.Size(65, 18);
            this.LogPanelTabControl.Location = new System.Drawing.Point(0, 0);
            this.LogPanelTabControl.Name = "LogPanelTabControl";
            this.LogPanelTabControl.SelectedIndex = 0;
            this.LogPanelTabControl.Size = new System.Drawing.Size(314, 139);
            this.LogPanelTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LogPanelTabControl.TabIndex = 0;
            // 
            // LogGeneralPage
            // 
            this.LogGeneralPage.Location = new System.Drawing.Point(4, 22);
            this.LogGeneralPage.Name = "LogGeneralPage";
            this.LogGeneralPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogGeneralPage.Size = new System.Drawing.Size(306, 113);
            this.LogGeneralPage.TabIndex = 0;
            this.LogGeneralPage.Text = "Log";
            this.LogGeneralPage.UseVisualStyleBackColor = true;
            // 
            // ReceivedPage
            // 
            this.ReceivedPage.Location = new System.Drawing.Point(4, 22);
            this.ReceivedPage.Name = "ReceivedPage";
            this.ReceivedPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReceivedPage.Size = new System.Drawing.Size(306, 113);
            this.ReceivedPage.TabIndex = 1;
            this.ReceivedPage.Text = "Received";
            this.ReceivedPage.UseVisualStyleBackColor = true;
            // 
            // SentPage
            // 
            this.SentPage.Location = new System.Drawing.Point(4, 22);
            this.SentPage.Name = "SentPage";
            this.SentPage.Padding = new System.Windows.Forms.Padding(3);
            this.SentPage.Size = new System.Drawing.Size(306, 113);
            this.SentPage.TabIndex = 2;
            this.SentPage.Text = "Sent";
            this.SentPage.UseVisualStyleBackColor = true;
            // 
            // LogDetailSettingsGroupBox
            // 
            this.LogDetailSettingsGroupBox.Controls.Add(this.ViewXMLCheckBox);
            this.LogDetailSettingsGroupBox.Controls.Add(this.WordWrapCheckBox);
            this.LogDetailSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogDetailSettingsGroupBox.Location = new System.Drawing.Point(3, 253);
            this.LogDetailSettingsGroupBox.Name = "LogDetailSettingsGroupBox";
            this.LogDetailSettingsGroupBox.Size = new System.Drawing.Size(300, 36);
            this.LogDetailSettingsGroupBox.TabIndex = 1;
            this.LogDetailSettingsGroupBox.TabStop = false;
            // 
            // ViewXMLCheckBox
            // 
            this.ViewXMLCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewXMLCheckBox.AutoSize = true;
            this.ViewXMLCheckBox.Location = new System.Drawing.Point(206, 13);
            this.ViewXMLCheckBox.Name = "ViewXMLCheckBox";
            this.ViewXMLCheckBox.Size = new System.Drawing.Size(88, 17);
            this.ViewXMLCheckBox.TabIndex = 1;
            this.ViewXMLCheckBox.Text = "View as XML";
            this.ViewXMLCheckBox.UseVisualStyleBackColor = true;
            this.ViewXMLCheckBox.CheckedChanged += new System.EventHandler(this.ViewXMLCheckBox_CheckedChanged);
            // 
            // WordWrapCheckBox
            // 
            this.WordWrapCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WordWrapCheckBox.AutoSize = true;
            this.WordWrapCheckBox.Location = new System.Drawing.Point(119, 13);
            this.WordWrapCheckBox.Name = "WordWrapCheckBox";
            this.WordWrapCheckBox.Size = new System.Drawing.Size(81, 17);
            this.WordWrapCheckBox.TabIndex = 0;
            this.WordWrapCheckBox.Text = "Word Wrap";
            this.WordWrapCheckBox.UseVisualStyleBackColor = true;
            this.WordWrapCheckBox.CheckedChanged += new System.EventHandler(this.WordWrapCheckBox_CheckedChanged);
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMLTextBox.Location = new System.Drawing.Point(3, 3);
            this.XMLTextBox.Name = "XMLTextBox";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.XMLTextBox.Settings = xmlViewerSettings1;
            this.XMLTextBox.Size = new System.Drawing.Size(300, 250);
            this.XMLTextBox.TabIndex = 0;
            this.XMLTextBox.Text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><html><head><title>My home page</title></h" +
    "ead><body bgcolor=\"000000\" text=\"ff0000\">Hello World!</body></html>\n";
            this.XMLTextBox.WordWrap = false;
            // 
            // LogDetailTabControl
            // 
            this.LogDetailTabControl.Controls.Add(this.LogDetailTabPage);
            this.LogDetailTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogDetailTabControl.Location = new System.Drawing.Point(0, 0);
            this.LogDetailTabControl.Name = "LogDetailTabControl";
            this.LogDetailTabControl.SelectedIndex = 0;
            this.LogDetailTabControl.Size = new System.Drawing.Size(314, 318);
            this.LogDetailTabControl.TabIndex = 2;
            // 
            // LogDetailTabPage
            // 
            this.LogDetailTabPage.Controls.Add(this.XMLTextBox);
            this.LogDetailTabPage.Controls.Add(this.LogDetailSettingsGroupBox);
            this.LogDetailTabPage.Location = new System.Drawing.Point(4, 22);
            this.LogDetailTabPage.Name = "LogDetailTabPage";
            this.LogDetailTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogDetailTabPage.Size = new System.Drawing.Size(306, 292);
            this.LogDetailTabPage.TabIndex = 0;
            this.LogDetailTabPage.Text = "Detail";
            this.LogDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // LogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogPanelGroupBox);
            this.Name = "LogPanel";
            this.Size = new System.Drawing.Size(320, 480);
            this.LogPanelGroupBox.ResumeLayout(false);
            this.SplitContainerLogPanel.Panel1.ResumeLayout(false);
            this.SplitContainerLogPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerLogPanel)).EndInit();
            this.SplitContainerLogPanel.ResumeLayout(false);
            this.LogPanelTabControl.ResumeLayout(false);
            this.LogDetailSettingsGroupBox.ResumeLayout(false);
            this.LogDetailSettingsGroupBox.PerformLayout();
            this.LogDetailTabControl.ResumeLayout(false);
            this.LogDetailTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogPanelGroupBox;
        private System.Windows.Forms.SplitContainer SplitContainerLogPanel;
        private System.Windows.Forms.TabControl LogPanelTabControl;
        private System.Windows.Forms.TabPage LogGeneralPage;
        private System.Windows.Forms.TabPage ReceivedPage;
        private System.Windows.Forms.TabPage SentPage;
        private System.Windows.Forms.GroupBox LogDetailSettingsGroupBox;
        private System.Windows.Forms.CheckBox ViewXMLCheckBox;
        private System.Windows.Forms.CheckBox WordWrapCheckBox;
        public XMLViewer XMLTextBox;
        private System.Windows.Forms.TabControl LogDetailTabControl;
        private System.Windows.Forms.TabPage LogDetailTabPage;
    }
}
