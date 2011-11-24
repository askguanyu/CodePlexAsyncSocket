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
            this.SendTextBox = new GY.NetAid.Controls.XMLViewer();
            this.SendSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SendSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendTextBox
            // 
            this.SendTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendTextBox.Location = new System.Drawing.Point(0, 0);
            this.SendTextBox.Name = "SendTextBox";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.SendTextBox.Settings = xmlViewerSettings1;
            this.SendTextBox.Size = new System.Drawing.Size(240, 165);
            this.SendTextBox.TabIndex = 0;
            this.SendTextBox.Text = "";
            // 
            // SendSettingsGroupBox
            // 
            this.SendSettingsGroupBox.Controls.Add(this.checkBox3);
            this.SendSettingsGroupBox.Controls.Add(this.checkBox2);
            this.SendSettingsGroupBox.Controls.Add(this.checkBox1);
            this.SendSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendSettingsGroupBox.Location = new System.Drawing.Point(0, 165);
            this.SendSettingsGroupBox.Name = "SendSettingsGroupBox";
            this.SendSettingsGroupBox.Size = new System.Drawing.Size(240, 155);
            this.SendSettingsGroupBox.TabIndex = 1;
            this.SendSettingsGroupBox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(103, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(151, 44);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SendPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.SendSettingsGroupBox);
            this.Name = "SendPanel";
            this.Size = new System.Drawing.Size(240, 320);
            this.SendSettingsGroupBox.ResumeLayout(false);
            this.SendSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XMLViewer SendTextBox;
        private System.Windows.Forms.GroupBox SendSettingsGroupBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
