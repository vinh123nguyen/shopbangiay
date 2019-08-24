using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        int p = 41;
        private void Formmain_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
            pictureBox1.Hide();
            panel1.Width = p;
        }   

        int d = 0;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                d = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                d = 0;
            }
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //bool mnuExpaned = false;

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (!bunifuTransition1.IsCompleted) return;
        //    if (panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
        //    {
        //        if (!mnuExpaned)
        //        {
        //            mnuExpaned = true;
        //            panel1.Visible = false;
        //            panel1.Width = 250;
        //            bunifuTransition1.Show(panel1);
        //        }
        //    }
        //    else
        //        if (mnuExpaned)
        //        {
        //            mnuExpaned = false;
        //            panel1.Visible = false;
        //            panel1.Width = 61;
        //            bunifuTransition1.Show(panel1);
        //        }
        //}

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == p)
            {
                panel1.Visible = false;
                panel1.Width = 255;
                pictureBox1.Show();
                bunifuTransition1.Show(panel1);
                bunifuImageButton1.Hide();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                panel1.Visible = false;
                panel1.Width = p;
                pictureBox1.Hide();
                bunifuImageButton1.Show();
                bunifuTransition1.Show(panel1);

            }
        }

        int newLocationX, newLocationY;
        private void Formmain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void Formmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender,e);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       

       
        
 
       
    }
}
