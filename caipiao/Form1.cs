using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace caipiao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                //this.listView1.Items.Add(string.Format("{0:000}", i));
                string ss = string.Format("{0:000}", i);


                //if (ss.IndexOf("0") < 0 && ss.IndexOf("1") < 0)
               // {
                    sb.Append(ss + " ");
                    n++;
               //}
            }
            this.textBox1.Text = sb.ToString();
            this.label1.Text = "共" + n + "注";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.label1.Text = "";
        }
    }
}
