namespace GY.NetAid.Controls
{
    partial class ServerModePanel
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
            this.SplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.ServerPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.ServerPanelSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ServerInfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.logPanel1 = new GY.NetAid.Controls.LogPanel();
            this.SendTabControl = new System.Windows.Forms.TabControl();
            this.SendTabPage = new System.Windows.Forms.TabPage();
            this.sendPanel = new GY.NetAid.Controls.SendPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.ServerPanelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPanelSplitContainer)).BeginInit();
            this.ServerPanelSplitContainer.Panel1.SuspendLayout();
            this.ServerPanelSplitContainer.Panel2.SuspendLayout();
            this.ServerPanelSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerInfoSplitContainer)).BeginInit();
            this.ServerInfoSplitContainer.SuspendLayout();
            this.SendTabControl.SuspendLayout();
            this.SendTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainerMain
            // 
            this.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerMain.Name = "SplitContainerMain";
            // 
            // SplitContainerMain.Panel1
            // 
            this.SplitContainerMain.Panel1.Controls.Add(this.ServerPanelGroupBox);
            // 
            // SplitContainerMain.Panel2
            // 
            this.SplitContainerMain.Panel2.Controls.Add(this.logPanel1);
            this.SplitContainerMain.Size = new System.Drawing.Size(640, 480);
            this.SplitContainerMain.SplitterDistance = 320;
            this.SplitContainerMain.TabIndex = 0;
            // 
            // ServerPanelGroupBox
            // 
            this.ServerPanelGroupBox.Controls.Add(this.ServerPanelSplitContainer);
            this.ServerPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerPanelGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ServerPanelGroupBox.Name = "ServerPanelGroupBox";
            this.ServerPanelGroupBox.Size = new System.Drawing.Size(320, 480);
            this.ServerPanelGroupBox.TabIndex = 0;
            this.ServerPanelGroupBox.TabStop = false;
            this.ServerPanelGroupBox.Text = "Server Info";
            // 
            // ServerPanelSplitContainer
            // 
            this.ServerPanelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerPanelSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.ServerPanelSplitContainer.Name = "ServerPanelSplitContainer";
            this.ServerPanelSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ServerPanelSplitContainer.Panel1
            // 
            this.ServerPanelSplitContainer.Panel1.Controls.Add(this.ServerInfoSplitContainer);
            // 
            // ServerPanelSplitContainer.Panel2
            // 
            this.ServerPanelSplitContainer.Panel2.Controls.Add(this.SendTabControl);
            this.ServerPanelSplitContainer.Size = new System.Drawing.Size(314, 461);
            this.ServerPanelSplitContainer.SplitterDistance = 175;
            this.ServerPanelSplitContainer.TabIndex = 0;
            // 
            // ServerInfoSplitContainer
            // 
            this.ServerInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerInfoSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ServerInfoSplitContainer.Name = "ServerInfoSplitContainer";
            this.ServerInfoSplitContainer.Size = new System.Drawing.Size(314, 175);
            this.ServerInfoSplitContainer.SplitterDistance = 159;
            this.ServerInfoSplitContainer.TabIndex = 0;
            // 
            // logPanel1
            // 
            this.logPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPanel1.Location = new System.Drawing.Point(0, 0);
            this.logPanel1.Name = "logPanel1";
            this.logPanel1.Size = new System.Drawing.Size(316, 480);
            this.logPanel1.TabIndex = 0;
            // 
            // SendTabControl
            // 
            this.SendTabControl.Controls.Add(this.SendTabPage);
            this.SendTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTabControl.Location = new System.Drawing.Point(0, 0);
            this.SendTabControl.Name = "SendTabControl";
            this.SendTabControl.SelectedIndex = 0;
            this.SendTabControl.Size = new System.Drawing.Size(314, 282);
            this.SendTabControl.TabIndex = 0;
            // 
            // SendTabPage
            // 
            this.SendTabPage.Controls.Add(this.sendPanel);
            this.SendTabPage.Location = new System.Drawing.Point(4, 22);
            this.SendTabPage.Name = "SendTabPage";
            this.SendTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SendTabPage.Size = new System.Drawing.Size(306, 256);
            this.SendTabPage.TabIndex = 0;
            this.SendTabPage.Text = "Send Message";
            this.SendTabPage.UseVisualStyleBackColor = true;
            // 
            // sendPanel
            // 
            this.sendPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendPanel.Location = new System.Drawing.Point(3, 3);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(300, 250);
            this.sendPanel.TabIndex = 0;
            // 
            // ServerModePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainerMain);
            this.Name = "ServerModePanel";
            this.Size = new System.Drawing.Size(640, 480);
            this.SplitContainerMain.Panel1.ResumeLayout(false);
            this.SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).EndInit();
            this.SplitContainerMain.ResumeLayout(false);
            this.ServerPanelGroupBox.ResumeLayout(false);
            this.ServerPanelSplitContainer.Panel1.ResumeLayout(false);
            this.ServerPanelSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerPanelSplitContainer)).EndInit();
            this.ServerPanelSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerInfoSplitContainer)).EndInit();
            this.ServerInfoSplitContainer.ResumeLayout(false);
            this.SendTabControl.ResumeLayout(false);
            this.SendTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.GroupBox ServerPanelGroupBox;
        private System.Windows.Forms.SplitContainer ServerPanelSplitContainer;
        private System.Windows.Forms.SplitContainer ServerInfoSplitContainer;
        private LogPanel logPanel1;
        private System.Windows.Forms.TabControl SendTabControl;
        private System.Windows.Forms.TabPage SendTabPage;
        private SendPanel sendPanel;
    }
}
