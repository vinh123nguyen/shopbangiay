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
    public partial class CTHD : Form
    {
        public CTHD( )
        {
            InitializeComponent();
        }
        //nhận dữ liệu
        public string Ten;
        public string Tennv
        {
            get { return Ten; }
            set { Ten = value; }
        }

        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtMahd.Text == "" || txtmanv.Text == "" || txtchietkhau.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
                  d = 1;
                  HOADONBAN hd = new HOADONBAN();
                  var kt = from s in db.HOADONBANs where s.MAHD == txtMahd.Text select s;
                  if (kt.Count() > 0)
                  {
                      MessageBox.Show("Trùng khóa chính");
                      return;
                  }
                  hd.MAHD = txtMahd.Text;
                  hd.NGAYLAP = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                  hd.MANV = txtmanv.Text;
                  hd.TONGTIEN = 0;
                  if (rdb_kvl.Checked == true)
                  {
                      txt_kvl.Visible = true;
                      hd.KHVANGLAI = txt_kvl.Text;
                      txt_kvl.Text=db.SINHMA_KH();
                      txtMahd.Text = db.SINHMA_HDB();
                  }
                  else
                  {
                      txtmakh.Visible = true;
                      hd.KHVANGLAI = txtmakh.Text;
                  }
                  hd.CHIECKHAU = Convert.ToDouble(txtchietkhau.Text.ToString());
                  db.HOADONBANs.InsertOnSubmit(hd);
                  db.SubmitChanges();
                  this.hOADONBANTableAdapter.Fill(this.dataSet_ShopGiay.HOADONBAN);
                  //CTHD_Load(sender, e);
                  MessageBox.Show("Thành công");
           
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Them_CTHD t = new Them_CTHD(this);
            //t.Message = txtMahd.Text.ToString();
            //t.Show();
            t.UpdateEventHandler += F2_UpdateEventHandler;
            t.Message = hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString();
            t.ShowDialog();
        
           
        }
        private void F2_UpdateEventHandler(object sender, Them_CTHD.UpdateEventArgs args)
        {
            this.banHangTableAdapter.Fill_hd(this.dataSet_ShopGiay.BanHang, hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString());
            CTHD_Load(sender, args);
        }
        private void hOADONBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        public int d = 0;
        private void CTHD_Load(object sender, EventArgs e)
        {            
            rdb_kvl.Checked = true;
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.BanHang' table. You can move, or remove it, as needed.
            //this.banHangTableAdapter.Fill(this.dataSet_ShopGiay.BanHang);

            // TODO: This line of code loads data into the 'dataSet_ShopGiay.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.dataSet_ShopGiay.KHUYENMAI);
            
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.HOADONBAN' table. You can move, or remove it, as needed.
            this.hOADONBANTableAdapter.Fill(this.dataSet_ShopGiay.HOADONBAN);
            txtMahd.Text = db.SINHMA_HDB();
            txtmanv.Text = Tennv;
            LBLKVL.Visible = txt_kvl.Visible = true;
            txt_kvl.Text = db.SINHMA_KH();

         
           
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void hOADONBANDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                d = 1;
                if (e.ColumnIndex == 7)
                {
                    var kt = (from bb in db.HOADONBANs
                              from ct in db.CHITIETHOADONBANs
                              where bb.MAHD == ct.MAHD && bb.MAHD == hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                    if (kt == 0)
                    {
                        txtMahd.Text = hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString();
                        var thanhvien = db.HOADONBANs.SingleOrDefault(tv => tv.MAHD == txtMahd.Text);
                        db.HOADONBANs.DeleteOnSubmit(thanhvien);
                        db.SubmitChanges();
                        CTHD_Load(sender, e);
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("không thể xóa");
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    txtmanv.Text = hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString();
                    var thanhvien = db.HOADONBANs.SingleOrDefault(tv => tv.MAHD == txtMahd.Text);
                    thanhvien.MANV = txtmanv.Text;
                    thanhvien.CHIECKHAU = Convert.ToDouble(txtchietkhau.Text);
                    thanhvien.CHIECKHAU = Convert.ToDouble(txtchietkhau.Text.ToString());
                    db.SubmitChanges();
                    CTHD_Load(sender, e);
                    MessageBox.Show("Thành công");
                }

            }
            catch
            {
                return;
            }
        }

        private void banHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 9)
            {

                var thanhvien = db.CHITIETHOADONBANs.SingleOrDefault(tv => tv.MACTHDB == banHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                db.CHITIETHOADONBANs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                CTHD_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 10)
            {

                var thanhvien = db.CHITIETHOADONBANs.SingleOrDefault(tv => tv.MACTHDB == banHangDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.SOLUONGBAN = Convert.ToInt32(banHangDataGridView.CurrentRow.Cells[4].Value.ToString());
                thanhvien.MAHD = banHangDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.MASP = banHangDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.SOSIZE = Convert.ToInt32(banHangDataGridView.CurrentRow.Cells[6].Value.ToString());
                db.SubmitChanges();
                CTHD_Load(sender, e);
                MessageBox.Show("Thành công");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt_tkhd_TextChanged(object sender, EventArgs e)
        {
            hOADONBANDataGridView.DataSource = db.XEMTT_HoaDonBan(txt_tkhd.Text.ToString());
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {
            banHangBindingSource.DataSource = db.XEMTT_CTHoaDonBan(txt_tk.Text.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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


        private void hOADONBANDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                this.banHangTableAdapter.Fill_hd(this.dataSet_ShopGiay.BanHang, hOADONBANDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void rdb_khtt_CheckedChanged(object sender, EventArgs e)
        {
            LBLKVL.Visible = txt_kvl.Visible = false;
            lBLKHTT.Visible = txtmakh.Visible = true;
        }

        private void rdb_kvl_CheckedChanged(object sender, EventArgs e)
        {
            lBLKHTT.Visible = txtmakh.Visible = false;
            LBLKVL.Visible = txt_kvl.Visible = true;
            
        }
    }
}
