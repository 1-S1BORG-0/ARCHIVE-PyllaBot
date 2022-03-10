using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyllaBot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Logger.Format;
            foreach (var logLevel in Enum.GetValues<LogLevel>())
            {
                comboBox1.Items.Add(logLevel);
            }
            foreach (var str in Logger.logs)
            {
                lock (logs.Text)
                    logs.Text += str + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logs.Text = String.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.LogLevel = (LogLevel)comboBox1.SelectedItem;
            Logger.Log("loglevel has changed to: " + (LogLevel)comboBox1.SelectedItem, LogLevel.Info);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Logger.Format = textBox1.Text;
        }
    }
}
