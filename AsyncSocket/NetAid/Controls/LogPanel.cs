using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GY.NetAid.Controls
{
    public partial class LogPanel : UserControl
    {
        public LogPanel()
        {
            InitializeComponent();
        }

        private void WordWrapCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.LogDetailTextBox.WordWrap = this.WordWrapCheckBox.Checked;
        }

        private void ViewXMLCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ViewXMLCheckBox.Checked)
            {
                try
                {
                    this.LogDetailTextBox.Process(true);
                }
                catch (Exception)
                {
                }
            }
            else
            {
                this.LogDetailTextBox.ResetXMLText();
            }
        }
    }
}
