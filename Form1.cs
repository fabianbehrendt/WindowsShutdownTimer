using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Text = "30";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.FileName = "cmd.exe";
            processInfo.WorkingDirectory = System.IO.Path.GetDirectoryName("cmd");
            processInfo.Arguments = "/c shutdown /a";
            Process.Start(processInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int time = Int32.Parse(comboBox.Text) * 60;

            Debug.WriteLine("test");

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.FileName = "cmd.exe";
            processInfo.WorkingDirectory = System.IO.Path.GetDirectoryName("cmd");
            processInfo.Arguments = "/c shutdown /s /t " + time;
            Process.Start(processInfo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
