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
    public partial class WELCOME : Form
    {
        public WELCOME()
        {
            InitializeComponent();
        }
       
        

        private void welcome_Load(object sender, EventArgs e)
        {
           

            
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
           PROFILE ob = new PROFILE();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have choosen PUBLIC NOTES");
            PUBNOT bj = new PUBNOT();
            bj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have choosen BROWSER");
            BROWSER obj = new BROWSER();
            obj.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have choosen PAINT");
            PAINT p = new PAINT();
            p.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\DK GOSWAMI\Desktop\images (12).jpg");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for Visiting!!!");
            login On = new login();
            On.Show();
            this.Hide();

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have choosen CALCULATOR");
            CALCULATOR cal = new CALCULATOR();
            cal.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
