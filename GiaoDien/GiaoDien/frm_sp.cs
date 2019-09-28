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
    public partial class frm_sp : Form
    {
        us_sp sp = new us_sp();
        public frm_sp()
        {
            InitializeComponent();
            comboBoxEx4.ForeColor = Color.LightGray;
            comboBoxEx4.Text = "Tìm kiếm theo tên giày";

            this.comboBoxEx4.Leave += new System.EventHandler(this.comboBoxEx4_Leave);
            this.comboBoxEx4.Enter += new System.EventHandler(this.comboBoxEx4_Enter);
        }
        private void comboBoxEx4_Enter(object sender, EventArgs e)
        {
            if (comboBoxEx4.Text == "Tìm kiếm theo tên giày")
            {
                comboBoxEx4.Text = "";
                comboBoxEx4.ForeColor = Color.Black;
            }

        }

        private void comboBoxEx4_Leave(object sender, EventArgs e)
        {
            if (comboBoxEx4.Text == "")
            {
                comboBoxEx4.Text = "Tìm kiếm theo tên giày";
                comboBoxEx4.ForeColor = Color.Gray;
            }

        }
        private void frm_sp_Load(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            sp.Width = panelEx1.Width;
            sp.Height = panelEx1.Height;
            panelEx1.Controls.Add(sp);
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEx4_Click(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }
    }
}
