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
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.NHACC' table. You can move, or remove it, as needed.
            this.nHACCTableAdapter.Fill(this.dataSet_ShopGiay.NHACC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.LOAIGIAY' table. You can move, or remove it, as needed.
            this.lOAIGIAYTableAdapter.Fill(this.dataSet_ShopGiay.LOAIGIAY);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DANHMUCSP' table. You can move, or remove it, as needed.
            this.dANHMUCSPTableAdapter.Fill(this.dataSet_ShopGiay.DANHMUCSP);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.NHACC' table. You can move, or remove it, as needed.
            this.nHACCTableAdapter.Fill(this.dataSet_ShopGiay.NHACC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.LOAIGIAY' table. You can move, or remove it, as needed.
            this.lOAIGIAYTableAdapter.Fill(this.dataSet_ShopGiay.LOAIGIAY);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DANHMUCSP' table. You can move, or remove it, as needed.
            this.dANHMUCSPTableAdapter.Fill(this.dataSet_ShopGiay.DANHMUCSP);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.LICHSUGIA' table. You can move, or remove it, as needed.
            this.lICHSUGIATableAdapter.Fill(this.dataSet_ShopGiay.LICHSUGIA);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet_ShopGiay.SANPHAM);
            //panelEx1.Controls.Clear();
            //sp.Width = panelEx1.Width;
            //sp.Height = panelEx1.Height;
            //panelEx1.Controls.Add(sp);
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
        int n=0;
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

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            SANPHAM bb = new SANPHAM();
            if (txtMasp.Text == "" || txtTensp.Text == "" || cboDMSP.Text == "" || txtTinhTrang.Text == "" || txtChatLieu.Text == ""
               || txtMau.Text == "" || cboLoai.Text == "" || txtgia.Text == "" || txtSoLuongsize.Text == "" || nHACCComboBox.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
            var kt = from s in db.SANPHAMs where s.MASP == txtMasp.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MASP = txtMasp.Text;
            bb.TENSP = txtTensp.Text;
            bb.MADMSP = cboDMSP.Text;
            bb.MAU = txtMau.Text;
            bb.CHATLIEU = txtChatLieu.Text;
            bb.GIA = Convert.ToDouble(txtgia.Text);
            bb.SOLUONGSIZE = Convert.ToInt16(txtSoLuongsize.Text);
            bb.TINHTRANGSP = txtTinhTrang.Text;
            bb.MALOAI = cboLoai.Text;
            bb.MANCC = nHACCComboBox.Text;
            db.SANPHAMs.InsertOnSubmit(bb);
            db.SubmitChanges();
            frm_sp_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var ktt = (from bb in db.SANPHAMs
                       from k in db.KHOs
                       from s in db.SIZEGIAYs
                       from ls in db.LICHSUGIAs
                       from tk in db.CTTKDs
                       where bb.MASP == ls.MASP && bb.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString() ||
                       tk.MASP == bb.MASP && bb.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString() ||
                       bb.MASP == s.MASP && bb.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString() ||
                       bb.MASP == k.MASP && bb.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString()
                       select bb).Count();
            if (ktt == 0)
            {
                var thanhvien = db.SANPHAMs.SingleOrDefault(tv => tv.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
                db.SANPHAMs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_sp_Load(sender, e);
                MessageBox.Show("thành công");
            }
            else
            {
                MessageBox.Show("không thể xóa");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var thanhvien = db.SANPHAMs.SingleOrDefault(tv => tv.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());

            thanhvien.MAU = sANPHAMDataGridView.CurrentRow.Cells[3].Value.ToString();
            thanhvien.CHATLIEU = sANPHAMDataGridView.CurrentRow.Cells[4].Value.ToString();
            thanhvien.GIA = Convert.ToDouble(sANPHAMDataGridView.CurrentRow.Cells[5].Value.ToString());
            thanhvien.SOLUONGSIZE = Convert.ToInt16(sANPHAMDataGridView.CurrentRow.Cells[6].Value.ToString());
            thanhvien.TINHTRANGSP = sANPHAMDataGridView.CurrentRow.Cells[7].Value.ToString();

            db.SubmitChanges();
            frm_sp_Load(sender, e);
            MessageBox.Show("thành công");
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
