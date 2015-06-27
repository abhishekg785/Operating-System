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
    public partial class login : Form
    {
        public login()
        {
            
            InitializeComponent();
            textBox1.Focus();
            password.PasswordChar = '*';
            password.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "abhishekg785" && password.Text == "hello@123")
            {
                PROFILE obj = new PROFILE();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
