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
    public partial class frm_nh : Form
    {
        public frm_nh()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            textBoxX1.ForeColor = Color.LightGray;
            textBoxX1.Text = "Tìm kiếm theo tên loại giày";

            this.textBoxX1.Leave += new System.EventHandler(this.textBoxX1_Leave);
            this.textBoxX1.Enter += new System.EventHandler(this.textBoxX1_Enter);

        }
        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "Tìm kiếm theo tên loại giày")
            {
                textBoxX1.Text = "";
                textBoxX1.ForeColor = Color.Black;
            }

        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                textBoxX1.Text = "Tìm kiếm theo tên loại giày";
                textBoxX1.ForeColor = Color.Gray;
            }

        }
        private void F2_UpdateEventHandler(object sender, themloaigiay.UpdateEventArgs args)
        {
            //vebanco();
            flpanel_hienthi.Controls.Clear();
            frm_nh_Load(sender,args);
        }

        int x_1 = 150;
        int y_1 = 120;
        int j = 40;
        int d = 0;
        int h = 6;

        public void vebanco(string s)
        {

            Button btn1 = new Button();
            {
                btn1.Width = x_1;
                btn1.Height = y_1;
                btn1.BackColor = Color.Azure;
                btn1.Text = s;
                btn1.Click += btn1_Click;

                d++;
            }
            flpanel_hienthi.Controls.Add(btn1);
            if (d == 6 || d == h)
            {

                h += 6;
            }
        }

        public void btn1_Click(object sender, EventArgs e)
        {
            frm_sp sp = new frm_sp();
            sp.Show();
        }
        private void buttonItem3_Click(object sender, EventArgs e)
        {
            themloaigiay t = new themloaigiay(this);
            t.UpdateEventHandler += F2_UpdateEventHandler;
            t.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            frm_nhaphang nh = new frm_nhaphang();
            nh.Show();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frm_DatHangNCC dh = new frm_DatHangNCC();
            dh.Show();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void frm_nh_Load(object sender, EventArgs e)
        {
            
            var f = (from s in db.LOAIGIAYs
                     select s.TENLOAI);
            int n = f.Count();
           
            foreach (var h in f.ToList())
            {
                vebanco(h.ToString());
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int n = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                n = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                n = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int newLocationX, newLocationY;
        private void CTHD_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void CTHD_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }
    }
}
