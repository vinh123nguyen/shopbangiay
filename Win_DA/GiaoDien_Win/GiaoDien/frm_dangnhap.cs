using GiaoDien.CLASS;
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
            txt_user.ForeColor = Color.Gray;
            txt_user.Text = "USER NAME";

            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            txt_pass.ForeColor = Color.Gray;
            txt_pass.Text = "PASSWORD";
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "PASSWORD")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.Gray;
            }

        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "PASSWORD";
                txt_pass.ForeColor = Color.Gray;
            }

        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "USER NAME")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.Gray;
            }
        }

        void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "USER NAME";
                txt_user.ForeColor = Color.Gray;
            }
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
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Formmain m = new Formmain();
            m.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_kn kn = new frm_kn();
            kn.Show();
        }
        kiemtradangnhap kt = new kiemtradangnhap();
        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            String b = "vui lòng không để trống";
            if (txt_user.Text.Length > 0 && txt_pass.Text.Length > 0)
            {
                if (kt.kiemtrataikhoan(txt_user.Text.ToString(), txt_pass.Text.ToString()) == true)
                {
                    Formmain main = new Formmain();
                    main.Tendn = txt_user.Text.ToString();
                    main.Show();
                    //Form1 m = new Form1();
                    //m.Tendn = txt_user.Text.ToString();
                    //m.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else
            {
                if (txt_pass.Text.Length == 0)
                {
                    b += " mật khẩu";
                }
                else
                    if (txt_user.Text.Length == 0)
                    {
                        b += " tên đăng nhập";
                    }
                MessageBox.Show(b);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
