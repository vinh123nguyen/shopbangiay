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
            textBoxX1.ForeColor = Color.LightGray;
            textBoxX1.Text = "Tìm kiếm theo tên loại giày";

            this.textBoxX1.Leave += new System.EventHandler(this.textBoxX1_Leave);
            this.textBoxX1.Enter += new System.EventHandler(this.textBoxX1_Enter);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vui lòng chọn đầu vào");

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
            vebanco();
        }

        int x_1 = 150;
        int y_1 = 120;
        int j = 40;
        int d = 0;
        int h = 6;

        public void vebanco()
        {
            Button btn1 = new Button();
            {
                btn1.Width = x_1;
                btn1.Height = y_1;
                btn1.BackColor = Color.Azure;
                btn1.Text = "Message";
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
    }
}
