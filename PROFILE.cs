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
    public partial class PROFILE : Form
    {
        string path;
        public PROFILE()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 1;
            timer1.Enabled = true;
            timer1.Interval = 20;
            if (toolStripProgressBar1.Value < 12)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;
            }

           OpenFileDialog obj = new OpenFileDialog();
            obj.ShowDialog();
            path = obj.FileName;
          pictureBox1.Image = Image.FromFile(path);
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                MessageBox.Show("succesfully uploaded");
      }
        public PROFILE(string s)
        {
            s = profiletext.Text.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

           
            WELCOME o = new WELCOME();
            o.Show();
            this.Hide();
        }

        private void profile_Load(object sender, EventArgs e)
        {
           
        }
    }
}
