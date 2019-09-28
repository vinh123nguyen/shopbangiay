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
    public partial class frm_kh : Form
    {
        public frm_kh()
        {
            InitializeComponent();
            textBoxX1.ForeColor = Color.LightGray;
            textBoxX1.Text = "Tìm kiếm theo số điện thoại";

            this.textBoxX1.Leave += textBoxX1_Leave;
            this.textBoxX1.Enter += textBoxX1_Enter;
        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "Tìm kiếm theo số điện thoại")
            {
                textBoxX1.Text = "";
                textBoxX1.ForeColor = Color.Black;
            }
        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                textBoxX1.Text = "Tìm kiếm theo số điện thoại";
                textBoxX1.ForeColor = Color.Gray;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_hskh kh = new frm_hskh();
            kh.Show();
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
