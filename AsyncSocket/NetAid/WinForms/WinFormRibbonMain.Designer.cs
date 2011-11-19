namespace GY.NetAid.WinForms
{
    partial class WinFormRibbonMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormRibbonMain));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.RibbonTabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ribbonPage1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ribbonPage2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ribbonPage3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RibbonSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerRightPanel = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RibbonTabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ribbonPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ribbonPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.ribbonPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RibbonSplitContainer)).BeginInit();
            this.RibbonSplitContainer.Panel1.SuspendLayout();
            this.RibbonSplitContainer.Panel2.SuspendLayout();
            this.RibbonSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightPanel)).BeginInit();
            this.splitContainerRightPanel.Panel1.SuspendLayout();
            this.splitContainerRightPanel.Panel2.SuspendLayout();
            this.splitContainerRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 540);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // RibbonTabContainer
            // 
            this.RibbonTabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RibbonTabContainer.Controls.Add(this.tabPage1);
            this.RibbonTabContainer.Controls.Add(this.tabPage2);
            this.RibbonTabContainer.Controls.Add(this.tabPage3);
            this.RibbonTabContainer.ItemSize = new System.Drawing.Size(65, 20);
            this.RibbonTabContainer.Location = new System.Drawing.Point(0, 0);
            this.RibbonTabContainer.Name = "RibbonTabContainer";
            this.RibbonTabContainer.SelectedIndex = 0;
            this.RibbonTabContainer.Size = new System.Drawing.Size(785, 100);
            this.RibbonTabContainer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.RibbonTabContainer.TabIndex = 3;
            this.RibbonTabContainer.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.RibbonTabContainer_Selecting);
            this.RibbonTabContainer.Selected += new System.Windows.Forms.TabControlEventHandler(this.RibbonTabContainer_Selected);
            this.RibbonTabContainer.Leave += new System.EventHandler(this.RibbonTabContainer_Leave);
            this.RibbonTabContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RibbonTabContainer_MouseClick);
            this.RibbonTabContainer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RibbonTabContainer_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ribbonPage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File";
            this.tabPage1.ToolTipText = "File";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbonPage1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbonPage1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ribbonPage1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.ribbonPage1.Location = new System.Drawing.Point(3, 3);
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Size = new System.Drawing.Size(771, 70);
            this.ribbonPage1.TabIndex = 0;
            this.ribbonPage1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 67);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.ribbonPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonPage2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbonPage2.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ribbonPage2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.ribbonPage2.Location = new System.Drawing.Point(3, 3);
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Size = new System.Drawing.Size(771, 70);
            this.ribbonPage2.TabIndex = 1;
            this.ribbonPage2.Text = "toolStrip4";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 67);
            this.toolStripButton3.Text = "Home";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.ribbonPage3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 72);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.BackColor = System.Drawing.SystemColors.Control;
            this.ribbonPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbonPage3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ribbonPage3.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ribbonPage3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout});
            this.ribbonPage3.Location = new System.Drawing.Point(3, 3);
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Size = new System.Drawing.Size(771, 70);
            this.ribbonPage3.TabIndex = 0;
            this.ribbonPage3.Text = "toolStrip2";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(52, 67);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Port,
            this.State});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 362);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 86;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 101;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 76;
            // 
            // RibbonSplitContainer
            // 
            this.RibbonSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RibbonSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RibbonSplitContainer.Location = new System.Drawing.Point(0, 100);
            this.RibbonSplitContainer.Name = "RibbonSplitContainer";
            // 
            // RibbonSplitContainer.Panel1
            // 
            this.RibbonSplitContainer.Panel1.Controls.Add(this.listView1);
            // 
            // RibbonSplitContainer.Panel2
            // 
            this.RibbonSplitContainer.Panel2.Controls.Add(this.splitContainerRightPanel);
            this.RibbonSplitContainer.Size = new System.Drawing.Size(784, 437);
            this.RibbonSplitContainer.SplitterDistance = 345;
            this.RibbonSplitContainer.SplitterWidth = 2;
            this.RibbonSplitContainer.TabIndex = 4;
            // 
            // splitContainerRightPanel
            // 
            this.splitContainerRightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightPanel.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightPanel.Name = "splitContainerRightPanel";
            // 
            // splitContainerRightPanel.Panel1
            // 
            this.splitContainerRightPanel.Panel1.Controls.Add(this.button1);
            // 
            // splitContainerRightPanel.Panel2
            // 
            this.splitContainerRightPanel.Panel2.Controls.Add(this.button2);
            this.splitContainerRightPanel.Size = new System.Drawing.Size(437, 437);
            this.splitContainerRightPanel.SplitterDistance = 210;
            this.splitContainerRightPanel.SplitterWidth = 2;
            this.splitContainerRightPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WinFormRibbonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.RibbonTabContainer);
            this.Controls.Add(this.RibbonSplitContainer);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinFormRibbonMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetAid";
            this.RibbonTabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ribbonPage1.ResumeLayout(false);
            this.ribbonPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ribbonPage2.ResumeLayout(false);
            this.ribbonPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ribbonPage3.ResumeLayout(false);
            this.ribbonPage3.PerformLayout();
            this.RibbonSplitContainer.Panel1.ResumeLayout(false);
            this.RibbonSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonSplitContainer)).EndInit();
            this.RibbonSplitContainer.ResumeLayout(false);
            this.splitContainerRightPanel.Panel1.ResumeLayout(false);
            this.splitContainerRightPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightPanel)).EndInit();
            this.splitContainerRightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.TabControl RibbonTabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip ribbonPage1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.SplitContainer RibbonSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainerRightPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip ribbonPage3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStrip ribbonPage2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}