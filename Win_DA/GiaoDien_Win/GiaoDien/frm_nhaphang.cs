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
    public partial class frm_nhaphang : Form
    {
        public frm_nhaphang()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void frm_nhaphang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUNHAPTableAdapter.Fill(this.dataSet_ShopGiay.CHITIETPHIEUNHAP);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.dataSet_ShopGiay.PHIEUNHAP);

        }

        private void pHIEUNHAPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var kt = (from bb in db.PHIEUNHAPs
                          from ct in db.CHITIETPHIEUNHAPs
                          where bb.MAPN == ct.MAPN && bb.MAPN == pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString()
                          && bb.MAPN==pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString()  select bb).Count();
                if (kt == 0)
                {
                    var thanhvien = db.PHIEUNHAPs.SingleOrDefault(tv => tv.MAPN == pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
                    db.PHIEUNHAPs.DeleteOnSubmit(thanhvien);

                    db.SubmitChanges();
                    frm_nhaphang_Load(sender, e);
                    MessageBox.Show("thành công");

                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }

            }
            if (e.ColumnIndex == 6)
            {
                var thanhvien = db.PHIEUNHAPs.SingleOrDefault(tv => tv.MAPN == pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.NGAYNHAP=Convert.ToDateTime(pHIEUNHAPDataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.TONGTIENNHAP=Convert.ToDouble(pHIEUNHAPDataGridView.CurrentRow.Cells[4].Value.ToString());
                db.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("thành công");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            pHIEUNHAPBindingSource.DataSource = db.XEMTT_PHIEUNHAP(txt_timkiem.Text.ToString());
        }

        private void txtimctpn_TextChanged(object sender, EventArgs e)
        {
            cHITIETPHIEUNHAPDataGridView.DataSource = db.XEMTT_CTPHIEUNHAP(txtimctpn.Text.ToString());
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUNHAP ct = new PHIEUNHAP();

                var kt = from s in db.PHIEUNHAPs where s.MANCC == pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString() select s;
                if (kt.Count() > 0)
                {
                    MessageBox.Show("Trùng khóa chính");
                    return;
                }
                ct.MAPN = pHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString();
                ct.MANV = pHIEUNHAPDataGridView.CurrentRow.Cells[1].Value.ToString();
                ct.MANCC = pHIEUNHAPDataGridView.CurrentRow.Cells[2].Value.ToString();
                ct.NGAYNHAP = Convert.ToDateTime(pHIEUNHAPDataGridView.CurrentRow.Cells[3].Value.ToString());
                ct.TONGTIENNHAP = Convert.ToInt32(pHIEUNHAPDataGridView.CurrentRow.Cells[4].Value.ToString());
                db.PHIEUNHAPs.InsertOnSubmit(ct);
                db.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("thành công");
            }
            catch
            {
                return;
            }
        }

        //private void cHITIETPHIEUNHAPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 6)
        //    {
                
                
        //            var thanhvien = db.CHITIETPHIEUNHAPs.SingleOrDefault(tv => tv.MACTPN == cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
        //            db.CHITIETPHIEUNHAPs.DeleteOnSubmit(thanhvien);

        //            db.SubmitChanges();
        //            frm_nhaphang_Load(sender, e);
        //            MessageBox.Show("thành công");

                

        //    }
        //    if (e.ColumnIndex == 7)
        //    {
        //        var thanhvien = db.CHITIETPHIEUNHAPs.SingleOrDefault(tv => tv.MACTPN == cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
        //        thanhvien.SOLUONGSP = Convert.ToInt32(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[3].Value.ToString());
        //        thanhvien.GIATIEN = Convert.ToDouble(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[4].Value.ToString());
               
        //        db.SubmitChanges();
        //        frm_nhaphang_Load(sender, e);
        //        MessageBox.Show("thành công");
        //    }
        //}

        private void btnthemctpn_Click(object sender, EventArgs e)
        {
            CHITIETPHIEUNHAP ct = new CHITIETPHIEUNHAP();
            var kt = from s in db.CHITIETPHIEUNHAPs where s.MACTPN == cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString() select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MACTPN = cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString();
            ct.MAPN = cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[1].Value.ToString();
            ct.MASP = cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[2].Value.ToString();
            ct.SOLUONGSP = Convert.ToInt32(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[3].Value.ToString());
            ct.GIATIEN = Convert.ToDouble(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[4].Value.ToString());
            db.CHITIETPHIEUNHAPs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_nhaphang_Load(sender, e);
            MessageBox.Show("thành công");
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

        private void cHITIETPHIEUNHAPDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {


                var thanhvien = db.CHITIETPHIEUNHAPs.SingleOrDefault(tv => tv.MACTPN == cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
                db.CHITIETPHIEUNHAPs.DeleteOnSubmit(thanhvien);

                db.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("thành công");



            }
            if (e.ColumnIndex == 6)
            {
                var thanhvien = db.CHITIETPHIEUNHAPs.SingleOrDefault(tv => tv.MACTPN == cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.SOLUONGSP = Convert.ToInt32(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.GIATIEN = Convert.ToDouble(cHITIETPHIEUNHAPDataGridView.CurrentRow.Cells[4].Value.ToString());

                db.SubmitChanges();
                frm_nhaphang_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }
    }
}
