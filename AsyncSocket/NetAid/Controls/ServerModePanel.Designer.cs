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
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerMain)).BeginInit();
            this.SplitContainerMain.Panel1.SuspendLayout();
            this.SplitContainerMain.Panel2.SuspendLayout();
            this.SplitContainerMain.SuspendLayout();
            this.ServerPanelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerPanelSplitContainer)).BeginInit();
            this.ServerPanelSplitContainer.Panel1.SuspendLayout();
            this.ServerPanelSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServerInfoSplitContainer)).BeginInit();
            this.ServerInfoSplitContainer.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.ServerPanelSplitContainer)).EndInit();
            this.ServerPanelSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServerInfoSplitContainer)).EndInit();
            this.ServerInfoSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainerMain;
        private System.Windows.Forms.GroupBox ServerPanelGroupBox;
        private System.Windows.Forms.SplitContainer ServerPanelSplitContainer;
        private System.Windows.Forms.SplitContainer ServerInfoSplitContainer;
        private LogPanel logPanel1;
    }
}
