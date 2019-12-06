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
    public partial class frm_ThemDDH : Form
    {
        public frm_ThemDDH(frm_DatHangNCC us)
        {
            InitializeComponent();
        }
        public delegate void updatedelegate(object sender, UpdateEventArgs args);
        public event updatedelegate UpdateEventHandler;


        public class UpdateEventArgs : EventArgs
        {
            public string data
            {
                get;
                set;
            }
        }
        protected void insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void pHIEUDATHANGNCCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATHANGNCCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void frm_ThemDDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet_ShopGiay.SANPHAM);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet_ShopGiay.SANPHAM);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
           // this.cHITIETPHIEUNHAPTableAdapter.Fill(this.dataSet_ShopGiay.CHITIETPHIEUNHAP);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.NHACC' table. You can move, or remove it, as needed.
            this.nHACCTableAdapter.Fill(this.dataSet_ShopGiay.NHACC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CTPHIEUDATHANGNCC' table. You can move, or remove it, as needed.
            this.cTPHIEUDATHANGNCCTableAdapter.Fill(this.dataSet_ShopGiay.CTPHIEUDATHANGNCC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.PHIEUDATHANGNCC' table. You can move, or remove it, as needed.
            this.pHIEUDATHANGNCCTableAdapter.Fill(this.dataSet_ShopGiay.PHIEUDATHANGNCC);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (txtSodonhang.Text == "" || cboNCC.Text == "" || txtnhanvien.Text == "" || datengaylap.Text == "" || txtTongtiennhap.Text == ""
              || txttinhtrang.Text == "" || txttientratruoc.Text == "" )
            {
                MessageBox.Show("không được để trống");
                return;
            }
            PHIEUDATHANGNCC ct = new PHIEUDATHANGNCC();
            var kt = from s in db.PHIEUDATHANGNCCs where s.SODONHANG == txtSodonhang.Text.ToString() select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("trùng khóa chính");
                return;
            }

            ct.SODONHANG = txtSodonhang.Text;
            ct.MANCC = cboNCC.Text;
            ct.MANV = txtnhanvien.Text;
            ct.NGAYLAP = Convert.ToDateTime(datengaylap.Text);
            ct.TONGTIENNHAP = Convert.ToDouble(txtTongtiennhap.Text);
            ct.TINHTRANGHANG = txttinhtrang.Text;
            ct.SOTIENTRATRUOC = Convert.ToDouble(txttientratruoc.Text);
            db.PHIEUDATHANGNCCs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_ThemDDH_Load(sender, e);
            insert();
            MessageBox.Show("thành công");
        }

        private void pHIEUDATHANGNCCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.PHIEUDATHANGNCCs
                      where s.SODONHANG == pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 7)
            {
                var ktt = (from bb in db.PHIEUDATHANGNCCs
                           from d in db.CTPHIEUDATHANGNCCs
                           where bb.SODONHANG == d.SODONHANG &&
                           d.SODONHANG == pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString()
                           select d).Count();
                if (ktt == 0)
                {
                    var thanhvien = db.PHIEUDATHANGNCCs.SingleOrDefault(tv => tv.SODONHANG == pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString());
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.PHIEUDATHANGNCCs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    frm_ThemDDH_Load(sender, e);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }
            }
            if (e.ColumnIndex == 8)
            {
                var thanhvien = db.PHIEUDATHANGNCCs.SingleOrDefault(tv => tv.SODONHANG == pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString());

                thanhvien.TINHTRANGHANG = pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[5].Value.ToString();              
                thanhvien.SOTIENTRATRUOC = Convert.ToDouble(pHIEUDATHANGNCCDataGridView.CurrentRow.Cells[6].Value.ToString());
                db.SubmitChanges();
                frm_ThemDDH_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            CTPHIEUDATHANGNCC ct = new CTPHIEUDATHANGNCC();
            if (sODONHANGTextEdit.Text == "" || sANPHAMComboBox.Text == "" || txtsl.Text == "" || txtdongia.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
            var kt = from s in db.CTPHIEUDATHANGNCCs where s.SODONHANG == sODONHANGTextEdit.Text.ToString() && s.MASP == sANPHAMComboBox.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("trùng khóa chính");
                return;
            }

            ct.SODONHANG = sODONHANGTextEdit.Text;
            ct.MASP = sANPHAMComboBox.Text;
            ct.SOLUONG = Convert.ToInt32(txtsl.Text);
            ct.DONGIA = Convert.ToDouble(txtdongia.Text);
            db.CTPHIEUDATHANGNCCs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_ThemDDH_Load(sender, e);
            insert();
            MessageBox.Show("thành công");
        }

        private void cTPHIEUDATHANGNCCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {


                var thanhvien = db.CTPHIEUDATHANGNCCs.SingleOrDefault(tv => tv.SODONHANG == cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[1].Value.ToString());

                db.CTPHIEUDATHANGNCCs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_ThemDDH_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 5)
            {
                var thanhvien = db.CTPHIEUDATHANGNCCs.SingleOrDefault(tv => tv.SODONHANG == cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[1].Value.ToString());
                thanhvien.SOLUONG = Convert.ToInt32(cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[2].Value.ToString());
                thanhvien.DONGIA = Convert.ToDouble(cTPHIEUDATHANGNCCDataGridView.CurrentRow.Cells[3].Value.ToString());
                db.SubmitChanges();
                frm_ThemDDH_Load(sender, e);
                MessageBox.Show("Thành công");
            }
                
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
