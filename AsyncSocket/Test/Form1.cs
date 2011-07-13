using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AsyncSocket;

namespace Test
{
    public partial class Form1 : Form
    {
        public AsyncSocketServer ss;

        public Form1()
        {
            InitializeComponent();
            ss = new AsyncSocketServer(9999);
            ss.Connected += new EventHandler<AsyncSocketUserToken>(ss_Connected);
            ss.DataReceived += new EventHandler<AsyncSocketUserToken>(ss_DataReceived);
            ss.DataSent += new EventHandler<AsyncSocketUserToken>(ss_DataSent);
            ss.Disconnected += new EventHandler<AsyncSocketUserToken>(ss_Disconnected);
            ss.ErrorOccurred += new EventHandler<AsyncSocketErrorEventArgs>(ss_ErrorOccurred);
        }

        void ss_ErrorOccurred(object sender, AsyncSocketErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        void ss_Disconnected(object sender, AsyncSocketUserToken e)
        {
            //throw new NotImplementedException();
        }

        void ss_DataSent(object sender, AsyncSocketUserToken e)
        {
            //throw new NotImplementedException();
        }

        void ss_DataReceived(object sender, AsyncSocketUserToken e)
        {
            string data = Encoding.Default.GetString(e.Data);

            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText(string.Format("ClientId: {0}, ip: {1}, port: {2}, received: {3}", e.ConnectionId.ToString(), e.EndPoint.Address.ToString(), e.EndPoint.Port.ToString(), data));
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.ScrollToCaret();
            });
        }

        void ss_Connected(object sender, AsyncSocketUserToken e)
        {
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ss.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ss.Stop();
        }
    }
}
