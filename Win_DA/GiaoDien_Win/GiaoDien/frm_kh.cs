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

        private void F2_UpdateEventHandler(object sender, frm_hskh.UpdateEventArgs args)
        {
            this.kHACHHANGTableAdapter.Fill(this.dataSet_ShopGiay.KHACHHANG);
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_hskh kh = new frm_hskh();
            
            kh.UpdateEventHandler += F2_UpdateEventHandler;
            kh.ShowDialog();
           
            this.WindowState = FormWindowState.Minimized;
        }

        private void frm_kh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataSet_ShopGiay.KHACHHANG);


        }
        DataClasses2DataContext db = new DataClasses2DataContext();

        private void kHACHHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var thanhvien = db.KHACHHANGs.SingleOrDefault(tv => tv.MAKH == kHACHHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            thanhvien.SDTKHACHHANG = Convert.ToInt32(kHACHHANGDataGridView.CurrentRow.Cells[2].Value.ToString());
            thanhvien.DIACHIKH = kHACHHANGDataGridView.CurrentRow.Cells[3].Value.ToString();
            db.SubmitChanges();
            frm_kh_Load(sender, e);
            MessageBox.Show("thành công");
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            kHACHHANGDataGridView.DataSource = db.XEMTT_TTKHACHHANG(textBoxX1.Text.ToString());
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
