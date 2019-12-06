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
    public partial class frm_kho : Form
    {
        public frm_kho()
        {
            InitializeComponent();
        }

        private void frm_kho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.NHACC' table. You can move, or remove it, as needed.
            this.nHACCTableAdapter.Fill(this.dataSet_ShopGiay.NHACC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.LOAIGIAY' table. You can move, or remove it, as needed.
            this.lOAIGIAYTableAdapter.Fill(this.dataSet_ShopGiay.LOAIGIAY);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DANHMUCSP' table. You can move, or remove it, as needed.
            this.dANHMUCSPTableAdapter.Fill(this.dataSet_ShopGiay.DANHMUCSP);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SIZEGIAY' table. You can move, or remove it, as needed.
            this.sIZEGIAYTableAdapter.Fill(this.dataSet_ShopGiay.SIZEGIAY);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.dataSet_ShopGiay.KHO);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet_ShopGiay.SANPHAM);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btnThemSp_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "" || txtTensp.Text == "" || dANHMUCSPComboBox.Text == "" || txtMau.Text == "" || txtChatLieu.Text == ""
                || txtGia.Text == "" || txtSLSize.Text == "" || txtTinhTRang.Text == "" || lOAIGIAYComboBox.Text == "" || nHACCComboBox.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
            SANPHAM bb = new SANPHAM();
            var kt = from s in db.SANPHAMs where s.MASP == txtMaSP.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MASP = txtMaSP.Text;
            bb.TENSP = txtTensp.Text;
            bb.MADMSP = dANHMUCSPComboBox.Text;
            bb.MAU = txtMau.Text;
            bb.CHATLIEU = txtChatLieu.Text;
            bb.GIA = Convert.ToDouble(txtGia.Text);
            bb.SOLUONGSIZE = Convert.ToInt16(txtSLSize.Text);
            bb.TINHTRANGSP = txtTinhTRang.Text;
            bb.MALOAI = lOAIGIAYComboBox.Text;
            bb.MANCC = nHACCComboBox.Text;
            db.SANPHAMs.InsertOnSubmit(bb);
            db.SubmitChanges();
            frm_kho_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void txtXoasp_Click(object sender, EventArgs e)
        {
             
                     var ktt = (from bb in db.SANPHAMs
                           from k in  db.KHOs 
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
                         frm_kho_Load(sender, e);
                         MessageBox.Show("thành công");
                     }
                     else
                     {
                         MessageBox.Show("không thể xóa");
                     }
                
               
          }
           

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            var thanhvien = db.SANPHAMs.SingleOrDefault(tv => tv.MASP == sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());

            thanhvien.MAU = sANPHAMDataGridView.CurrentRow.Cells[3].Value.ToString();
            thanhvien.CHATLIEU = sANPHAMDataGridView.CurrentRow.Cells[4].Value.ToString();
            thanhvien.GIA = Convert.ToDouble(sANPHAMDataGridView.CurrentRow.Cells[5].Value.ToString());
            thanhvien.SOLUONGSIZE = Convert.ToInt16(sANPHAMDataGridView.CurrentRow.Cells[6].Value.ToString());
            thanhvien.TINHTRANGSP = sANPHAMDataGridView.CurrentRow.Cells[7].Value.ToString();

            db.SubmitChanges();
            frm_kho_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            if (txtSP.Text == "" || txtDMSP.Text == "" || txtLoaiGiay.Text == "" || txtSOLUONG.Text == "" || txtTrangThai.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            KHO k = new KHO();
            var kt = from s in db.KHOs where s.MASP == txtMaSP.Text && s.MADMSP == txtDMSP.Text && s.MALOAI == txtLoaiGiay.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            k.MASP = txtSP.Text;
            k.MADMSP = txtDMSP.Text;
            k.MALOAI = txtLoaiGiay.Text;
            k.SOLUONG = Convert.ToInt16(txtSOLUONG.Text);
            k.TRANGTHAI = txtTrangThai.Text;
            db.KHOs.InsertOnSubmit(k);
            db.SubmitChanges();
            frm_kho_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void txtSOLUONG_TextChanged(object sender, EventArgs e)
        {

        }

        private void kHODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.KHOs
                      where s.MASP == kHODataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 5)
            {

                var thanhvien = db.KHOs.SingleOrDefault(tv => tv.MASP == kHODataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MADMSP == kHODataGridView.CurrentRow.Cells[1].Value.ToString() && tv.MALOAI == kHODataGridView.CurrentRow.Cells[2].Value.ToString());
                if (kt.Count() == 0)
                {
                    return;
                }
                db.KHOs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_kho_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 6)
            {
                var thanhvien = db.KHOs.SingleOrDefault(tv => tv.MASP == kHODataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MADMSP == kHODataGridView.CurrentRow.Cells[1].Value.ToString() && tv.MALOAI == kHODataGridView.CurrentRow.Cells[2].Value.ToString());
                thanhvien.SOLUONG = Convert.ToInt32(kHODataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.TRANGTHAI = kHODataGridView.CurrentRow.Cells[4].Value.ToString();
                db.SubmitChanges();
                frm_kho_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }

        private void btnThemSize_Click(object sender, EventArgs e)
        {
            if (cboMaspsize.Text == "" || txtsosize.Text == "" || txtSLsizegiay.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            SIZEGIAY k = new SIZEGIAY();
            var kt = from s in db.SIZEGIAYs where s.MASP == txtMaSP.Text && s.SOSIZE == Convert.ToInt16(txtsosize.Text) select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            k.MASP = cboMaspsize.Text;
            k.SOSIZE = Convert.ToInt16(txtsosize.Text);
            k.SOLUONGTON = Convert.ToInt16(txtSLsizegiay.Text);
            db.SIZEGIAYs.InsertOnSubmit(k);
            db.SubmitChanges();
            frm_kho_Load(sender, e);
            MessageBox.Show("Thành công");
        }

        private void sIZEGIAYDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
               var thanhvien = db.SIZEGIAYs.SingleOrDefault(tv => tv.MASP == sIZEGIAYDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.SOSIZE == Convert.ToInt16(sIZEGIAYDataGridView.CurrentRow.Cells[1].Value.ToString()));
                db.SIZEGIAYs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_kho_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 4)
            {
                var thanhvien = db.SIZEGIAYs.SingleOrDefault(tv => tv.MASP == sIZEGIAYDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.SOSIZE == Convert.ToInt16(sIZEGIAYDataGridView.CurrentRow.Cells[1].Value.ToString()));
                thanhvien.SOLUONGTON = Convert.ToInt16(sIZEGIAYDataGridView.CurrentRow.Cells[2].Value.ToString());
                db.SubmitChanges();
                frm_kho_Load(sender, e);
                MessageBox.Show("Thành công");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_tkSP_TextChanged(object sender, EventArgs e)
        {
            sANPHAMDataGridView.DataSource = db.XEMTT_SANPHAM(TXT_tkSP.Text.ToString());
        }

        private void sANPHAMDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kHODataGridView.DataSource = db.XEMTT_kHO(textBox1.Text.ToString());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            sIZEGIAYDataGridView.DataSource = db.XEMTT_SIZE(textBox8.Text.ToString());
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
