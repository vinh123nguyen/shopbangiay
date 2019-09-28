using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
            textBoxX1.ForeColor = Color.Gray;
            textBoxX1.Text = "USER NAME";

            this.textBoxX1.Leave += new System.EventHandler(this.textBoxX1_Leave);
            this.textBoxX1.Enter += new System.EventHandler(this.textBoxX1_Enter);
            textBoxX2.ForeColor = Color.Gray;
            textBoxX2.Text = "PASSWORD";
            this.textBoxX2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBoxX2.Enter += new System.EventHandler(this.textBox2_Enter);
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBoxX2.Text == "PASSWORD")
            {
                textBoxX2.Text = "";
                textBoxX2.ForeColor = Color.Gray;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBoxX2.Text == "")
            {
                textBoxX2.Text = "PASSWORD";
                textBoxX2.ForeColor = Color.Gray;
            }

        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "USER NAME")
            {
                textBoxX1.Text = "";
                textBoxX1.ForeColor = Color.Gray;
            }
        }

        void textBoxX1_Leave(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                textBoxX1.Text = "USER NAME";
                textBoxX1.ForeColor = Color.Gray;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int newLocationX, newLocationY;
        private void frm_dangnhap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void frm_dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }

        private void bunifuCustomLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseDown(sender, e);
        }

        private void bunifuCustomLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseMove(sender, e);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseMove(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseDown(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            frm_dangnhap_MouseMove(sender, e);
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
