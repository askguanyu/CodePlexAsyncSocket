using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GY.NetAid.WinForms
{
    public partial class WinFormMain : Form
    {
        public WinFormMain()
        {
            InitializeComponent();
        }

        private void tabPage1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.splitContainer1.SplitterDistance == 100)
            {
                this.splitContainer1.SplitterDistance = 22; 
            }
            else
            {
                this.splitContainer1.SplitterDistance = 100;
            }
        }
    }
}
