using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class User_ds : UserControl
    {
        public User_ds()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxX1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void User_ds_Load(object sender, EventArgs e)
        {
            textBoxX1.ForeColor = Color.Gray;
            textBoxX1.Text = "Tìm kiếm theo mã";

            this.textBoxX1.Leave += textBoxX1_Leave;
            this.textBoxX1.Enter += textBoxX1_Enter;
        }

        void textBoxX1_Enter(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "Tìm kiếm theo mã")
            {
                textBoxX1.Text = "";
                textBoxX1.ForeColor = Color.Gray;
            }
        }

        void textBoxX1_Leave(object sender, EventArgs e)
        {

            if (textBoxX1.Text == "")
            {
                textBoxX1.Text = "Tìm kiếm theo mã";
                textBoxX1.ForeColor = Color.Gray;
            }
        }

    
      

    }
}
