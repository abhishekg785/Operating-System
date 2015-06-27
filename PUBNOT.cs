using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace login
{
    public partial class PUBNOT : Form
    {
        public PUBNOT()
        {
            InitializeComponent();
        }

        private void publicnotes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.ShowDialog();
            textBox1.Text = obj.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader t = new StreamReader(textBox1.Text);
            richTextBox1.Text = t.ReadToEnd(); 
            t.Close();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.Text = richTextBox2.Text = " ";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(textBox1.Text,true);
            wr.WriteLine(richTextBox2.Text);
            wr.Close();
            MessageBox.Show("successfully written");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WELCOME w = new WELCOME();
            w.Show();
            this.Hide();
        }
    }
}
