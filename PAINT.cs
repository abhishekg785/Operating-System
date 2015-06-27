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
    public partial class PAINT : Form
    {
        bool paint;
      public SolidBrush color;
      public int k;
     public PAINT()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color =new SolidBrush(colorDialog1.Color);
            k = 1;
       

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (k != 1)
                {
                    color = new SolidBrush(Color.Black);
                }
                Graphics g = panel1.CreateGraphics();
                g.FillEllipse(color, e.X, e.Y, 10, 10);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Graphics c = panel1.CreateGraphics();
            c.Clear(panel1.BackColor);
            
        }

        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            WELCOME p = new WELCOME();
            p.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog();
            obj.DefaultExt = "*.png";
            obj.ShowDialog();
           
           
        }
    }
}
