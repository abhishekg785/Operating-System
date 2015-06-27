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
    public partial class BROWSER : Form
    {
        public BROWSER()
        {
            InitializeComponent();
           
        }

        private void BROWSER_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 1;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            if (toolStripProgressBar1.Value < 15)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;
            }
      }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (mybrowser.CanGoBack)
            {
                mybrowser.GoBack();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (mybrowser.CanGoForward)
            {
                mybrowser.GoForward();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            mybrowser.Stop();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            mybrowser.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string s = "http://" + toolStripTextBox1.Text;
            mybrowser.Navigate(s);
        }

        private void mybrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WELCOME ct=new WELCOME();
            ct.Show();
            this.Hide();
        }
    }
}
