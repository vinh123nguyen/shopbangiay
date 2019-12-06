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
    public partial class DDHKhachHang : Form
    {
        public DDHKhachHang()
        {
            InitializeComponent();
        }

        private void dONDATHANGKHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dONDATHANGKHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

       
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btn_themddh_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "" || txtkh.Text == "" || txt_tongsl.Text == "" || date_ngaydat.Text == "" || txt_tongtien.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

                DONDATHANGKH bb = new DONDATHANGKH();
                var kt = from s in db.DONDATHANGKHs where s.MADH == txtma.Text select s;
                if (kt.Count() > 0)
                {
                    MessageBox.Show("Trùng khóa chính");
                    return;
                }
                bb.MADH = txtma.Text;
                bb.MAKH = txtkh.Text;
                bb.TONGSLSANPHAM = Convert.ToInt32(txt_tongsl.Text.ToString());
                bb.NGAYDAT = Convert.ToDateTime(date_ngaydat.Text.ToString());
                bb.TONGTIEN = Convert.ToDouble(txt_tongtien.Text.ToString());
                db.DONDATHANGKHs.InsertOnSubmit(bb);
                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");
            
          
            
        }

        private void dONDATHANGKHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var kt = (from bb in db.DONDATHANGKHs
                          from ct in db.CHITIETDDHKHACHHANGs
                          from gh in db.GIAOHANGs
                          where bb.MADH == ct.MADH  && bb.MADH == dONDATHANGKHDataGridView.CurrentRow.Cells[0].Value.ToString()
                          ||bb.MADH == gIAOHANGDataGridView.CurrentRow.Cells[0].Value.ToString() && bb.MADH == gh.MADH
                          select bb).Count();
                if (kt == 0)
                {
                    var thanhvien = db.DONDATHANGKHs.SingleOrDefault(tv => tv.MADH == dONDATHANGKHDataGridView.CurrentRow.Cells[0].Value.ToString());
                    db.DONDATHANGKHs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                  DDHKhachHang_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }
            }
            if (e.ColumnIndex == 6)
            {

                var thanhvien = db.DONDATHANGKHs.SingleOrDefault(tv => tv.MADH == dONDATHANGKHDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MAKH == dONDATHANGKHDataGridView.CurrentRow.Cells[1].Value.ToString());
                thanhvien.TONGSLSANPHAM = Convert.ToInt16(dONDATHANGKHDataGridView.CurrentRow.Cells[2].Value.ToString());
                thanhvien.MAKH = dONDATHANGKHDataGridView.CurrentRow.Cells[1].Value.ToString();

                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtmadh.Text == "" || txtmahd.Text == "" || txt_manv.Text == "" || date_ngaygiao.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            GIAOHANG bb = new GIAOHANG();
            var kt = from s in db.GIAOHANGs where s.MADH == txtmadh.Text && s.MAHD == txtmahd.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MADH = txtmadh.Text;
            bb.MAHD = txtmahd.Text;
            bb.MANVGIAOHANG = txt_manv.Text;
            bb.NGAYGIOGIAOHANG = Convert.ToDateTime(date_ngaygiao.Text.ToString());
            if (radio_danggiao.Checked == true)
            {
                bb.TINHTRANG = radio_danggiao.Text;
            }
            else
            {
                bb.TINHTRANG = radio_dagiao.Text;
            }

            db.GIAOHANGs.InsertOnSubmit(bb);
            db.SubmitChanges();

            DDHKhachHang_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void gIAOHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                var thanhvien = db.GIAOHANGs.SingleOrDefault(tv => tv.MADH == gIAOHANGDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MAHD == gIAOHANGDataGridView.CurrentRow.Cells[1].Value.ToString());
                db.GIAOHANGs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");


            }
            if (e.ColumnIndex == 6)
            {

                //var thanhvien = db.GIAOHANGs.SingleOrDefault(tv => tv.MADH ==dONDATHANGKHDataGridView.CurrentRow.Cells[0].Value.ToString());
                var thanhvien = db.GIAOHANGs.SingleOrDefault(tv => tv.MADH == gIAOHANGDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MAHD == gIAOHANGDataGridView.CurrentRow.Cells[1].Value.ToString());
                thanhvien.MANVGIAOHANG = gIAOHANGDataGridView.CurrentRow.Cells[2].Value.ToString();

                if (radio_dagiao.Checked == true)
                {
                    thanhvien.TINHTRANG = radio_dagiao.Text;

                }
                else
                        thanhvien.TINHTRANG = radio_danggiao.Text;
                    
                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_Mahoadon.Text == "" || txtmasp.Text == "" || txtsl.Text == "" || txtgiatien.Text == "")
            {
                MessageBox.Show("thành công");
                return;
            }
            CHITIETDDHKHACHHANG bb = new CHITIETDDHKHACHHANG();
            var kt = from s in db.CHITIETDDHKHACHHANGs where s.MADH == txtmadh.Text && s.MASP == txtmasp.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MADH = txt_Mahoadon.Text;
            bb.MASP = txtmasp.Text;
            bb.SOLUONGSP = Convert.ToInt32(txtsl.Text.ToString());
            bb.GIATIEN = Convert.ToDouble(txtgiatien.Text.ToString());
            db.CHITIETDDHKHACHHANGs.InsertOnSubmit(bb);
            db.SubmitChanges();
           DDHKhachHang_Load(sender, e);
            MessageBox.Show("thành công");

        }

        private void cHITIETDDHKHACHHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                var thanhvien = db.CHITIETDDHKHACHHANGs.SingleOrDefault(tv => tv.MADH == cHITIETDDHKHACHHANGDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == txtmasp.Text);
                db.CHITIETDDHKHACHHANGs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");
            }
            if (e.ColumnIndex == 5)
            {

                var thanhvien = db.CHITIETDDHKHACHHANGs.SingleOrDefault(tv => tv.MADH == cHITIETDDHKHACHHANGDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == cHITIETDDHKHACHHANGDataGridView.CurrentRow.Cells[1].Value.ToString());
                thanhvien.SOLUONGSP = Convert.ToInt16(cHITIETDDHKHACHHANGDataGridView.CurrentRow.Cells[2].Value.ToString());
                thanhvien.GIATIEN = Convert.ToDouble(cHITIETDDHKHACHHANGDataGridView.CurrentRow.Cells[3].Value.ToString());

                db.SubmitChanges();
                DDHKhachHang_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void DDHKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DONDATHANGKH' table. You can move, or remove it, as needed.
            this.dONDATHANGKHTableAdapter.Fill(this.dataSet_ShopGiay.DONDATHANGKH);
            this.cHITIETDDHKHACHHANGTableAdapter.Fill(this.dataSet_ShopGiay.CHITIETDDHKHACHHANG);
            this.gIAOHANGTableAdapter.Fill(this.dataSet_ShopGiay.GIAOHANG);
        }

        private void txt_timctddhkh_TextChanged(object sender, EventArgs e)
        {
            cHITIETDDHKHACHHANGDataGridView.DataSource = db.XEMTT_CTDDHKH(txt_timctddhkh.Text.ToString());
        }

        private void txt_timddh_TextChanged(object sender, EventArgs e)
        {
            dONDATHANGKHDataGridView.DataSource = db.XEMTT_DDHKH(txt_timddh.Text.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int n;
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


        private void buttonX2_Click(object sender, EventArgs e)
        {
            CTHD ct = new CTHD();
            ct.Show();
        }
    }
}
