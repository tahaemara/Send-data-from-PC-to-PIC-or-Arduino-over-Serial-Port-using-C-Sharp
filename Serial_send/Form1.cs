using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace Serial_send
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = comboBox1.Text.ToString();
            string s = textBox1.Text.ToString();
            sErial(t, s);
        }

        void sErial(string Port_name, string data_send)
        {
            SerialPort sp = new SerialPort(Port_name, 9600, Parity.None, 8, StopBits.One);
            sp.Open();

            sp.Write(data_send);
            sp.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.youtube.com/user/omar0103637");
        }

    }
}
