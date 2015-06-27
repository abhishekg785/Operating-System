using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class CALCULATOR : Form
    {
        double i, j, res;
        public CALCULATOR()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            res = i + j;
            textBox3.Text = res.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            res = i - j;
            textBox3.Text = res.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            res = i * j;
            textBox3.Text = res.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            i = int.Parse(textBox1.Text);
            j = int.Parse(textBox2.Text);
            res = i / j;
            textBox3.Text = res.ToString();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WELCOME o = new WELCOME();
            o.Show();
            this.Hide();

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            i = double.Parse(textBox4.Text);
            res = Math.Sqrt(i);
            textBox5.Text = res.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            i = double.Parse(textBox4.Text);
            res = Math.Log(i);
            textBox5.Text = res.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            i = double.Parse(textBox4.Text);
            res = Math.Log10(i);
            textBox5.Text = res.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            i = double.Parse(textBox4.Text);
            res = Math.Round(i);
            textBox5.Text = res.ToString();
        }

       
        
    }
}
