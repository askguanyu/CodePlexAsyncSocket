﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncSocket;

namespace AsyncSocketTestWinForm
{
    public partial class WinFormMain : Form
    {
        public AsyncSocketServer ss;
        private long maxClient;

        public WinFormMain()
        {
            InitializeComponent();
            ss = new AsyncSocketServer(new IPEndPoint(IPAddress.Any, Convert.ToInt32(this.numericUpDown1.Value)));
        }

        void ss_ErrorOccurred(object sender, AsyncSocketServerErrorEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText(string.Format("----Error: {0}", e.Exception.Message));
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.ScrollToCaret();
            });
        }

        void ss_Disconnected(object sender, AsyncSocketServerUserToken e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    richTextBox1.AppendText(string.Format("->Left clients: {0}, Disconnected ClientId: {1}, ip: {2}, port: {3}", ss.NumConnectedSockets.ToString(), e.ConnectionId.ToString(), e.EndPoint.Address.ToString(), e.EndPoint.Port));
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.ScrollToCaret();
                }
                catch
                {
                }
            });
        }

        void ss_DataSent(object sender, AsyncSocketServerUserToken e)
        {
            //throw new NotImplementedException();
        }

        void ss_DataReceived(object sender, AsyncSocketServerUserToken e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (richTextBox1.TextLength > 536870912)
                {
                    richTextBox1.Clear();
                }
            });

            //string data = Encoding.Default.GetString(e.ReceivedRawData);

            //this.Invoke((MethodInvoker)delegate
            //{
            //    try
            //    {
            //        richTextBox1.AppendText(string.Format("----ClientId: {0}, ip: {1}, port: {2}, received: {3}", e.ConnectionId.ToString(), e.EndPoint.Address.ToString(), e.EndPoint.Port.ToString(), data));
            //        richTextBox1.AppendText(Environment.NewLine);
            //        richTextBox1.ScrollToCaret();
            //    }
            //    catch
            //    {
            //    }
            //});

            //ss.Send(e.ConnectionId, e.ReceivedRawData);
        }

        void ss_Connected(object sender, AsyncSocketServerUserToken e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                try
                {
                    richTextBox1.AppendText(string.Format("-> Total client: {3}, Connected ClientId: {0}, ip: {1}, port: {2}", e.ConnectionId.ToString(), e.EndPoint.Address.ToString(), e.EndPoint.Port.ToString(), ss.NumConnectedSockets));
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.ScrollToCaret();
                }
                catch
                {
                }

                if (ss.NumConnectedSockets >= this.maxClient)
                {
                    this.maxClient = ss.NumConnectedSockets;
                }

                label4.Text = this.maxClient.ToString();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!ss.IsListening)
            {
                ss = new AsyncSocketServer(new IPEndPoint(IPAddress.Any, Convert.ToInt32(this.numericUpDown1.Value)), Convert.ToInt32(this.numericUpDown2.Value), Convert.ToInt32(this.numericUpDown3.Value));
                ss.Connected += new EventHandler<AsyncSocketServerUserToken>(ss_Connected);
                ss.DataReceived += new EventHandler<AsyncSocketServerUserToken>(ss_DataReceived);
                ss.DataSent += new EventHandler<AsyncSocketServerUserToken>(ss_DataSent);
                ss.Disconnected += new EventHandler<AsyncSocketServerUserToken>(ss_Disconnected);
                ss.ErrorOccurred += new EventHandler<AsyncSocketServerErrorEventArgs>(ss_ErrorOccurred);

                try
                {
                    ss.Start();

                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.AppendText(string.Format("-> Server start to listening port: {0}", ss.LocalEndPoint.Port));
                        richTextBox1.AppendText(Environment.NewLine);
                        richTextBox1.ScrollToCaret();
                    });
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText(string.Format("-> Server is listening port: {0}", ss.LocalEndPoint.Port));
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.ScrollToCaret();
                });
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ss.IsListening)
            {
                try
                {
                    ss.Stop();

                    this.Invoke((MethodInvoker)delegate
                    {
                        //ss.Connected -= new EventHandler<AsyncSocketUserToken>(ss_Connected);
                        //ss.DataReceived -= new EventHandler<AsyncSocketUserToken>(ss_DataReceived);
                        //ss.DataSent -= new EventHandler<AsyncSocketUserToken>(ss_DataSent);
                        //ss.Disconnected -= new EventHandler<AsyncSocketUserToken>(ss_Disconnected);
                        //ss.ErrorOccurred -= new EventHandler<AsyncSocketErrorEventArgs>(ss_ErrorOccurred);

                        richTextBox1.AppendText("-> Server stop!");
                        richTextBox1.AppendText(Environment.NewLine);
                        richTextBox1.ScrollToCaret();
                    });
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText("-> Server is stoped!");
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox1.ScrollToCaret();
                });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                label7.Text = ss.NumConnectedSockets.ToString();
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                label4.Text = "0";
                label7.Text = "0";
                richTextBox1.Clear();
            });
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            AsyncSocketClient client = new AsyncSocketClient();
            client.SendOnce("127.0.0.1", 9999, "hello".ToHexByte());
        }
    }
}
