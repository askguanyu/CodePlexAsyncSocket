﻿using System;
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
            
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (this.tabControl1.Height == 20)
            {
                this.tabControl1.Height = 100;
            }
            else
            {
                this.tabControl1.Height = 20;
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
