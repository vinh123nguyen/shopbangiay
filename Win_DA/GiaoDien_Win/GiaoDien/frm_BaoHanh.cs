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
    public partial class frm_BaoHanh : Form
    {
        public frm_BaoHanh()
        {
            InitializeComponent();
        }

        private void pHIEUBAOHANHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUBAOHANHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void frm_BaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CTTKDS' table. You can move, or remove it, as needed.
            //this.cTTKDSTableAdapter.Fill(this.dataSet_ShopGiay.CTTKDS);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.PHIEUBAOHANH' table. You can move, or remove it, as needed.
            this.pHIEUBAOHANHTableAdapter.Fill(this.dataSet_ShopGiay.PHIEUBAOHANH);
            txt_mapbh.Text = db.SINHMA_PBH();

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void pHIEUBAOHANHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           var kt = (from s in db.PHIEUBAOHANHs
                         where s.MABH== pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString()
                         select new
                         {
                             s
                         });
            if (e.ColumnIndex == 5)
            {
                 var ktx = (from bb in db.PHIEUBAOHANHs
                              from ct in db.CHITIETHOADONBANs where bb.MABH == ct.MABH && bb.MABH==pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                 if (ktx == 0)
                 {
                     txt_mapbh.Text = pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString();
                     var thanhvien = db.PHIEUBAOHANHs.SingleOrDefault(tv => tv.MABH == pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString());
                     if (kt.Count() == 0)
                     {
                         return;
                     }
                     db.PHIEUBAOHANHs.DeleteOnSubmit(thanhvien);
                     db.SubmitChanges();
                     frm_BaoHanh_Load(sender, e);
                     MessageBox.Show("thành công");
                 }
                 else
                 {
                     MessageBox.Show("Không thể xóa");
                 }
            }
            if (e.ColumnIndex == 6)
            {
                txt_mapbh.Text = pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString();
                var thanhvien = db.PHIEUBAOHANHs.SingleOrDefault(tv => tv.MABH == pHIEUBAOHANHDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.MAKH = pHIEUBAOHANHDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.NGAYHETHANDOITRA = Convert.ToDateTime(dateEdit1.Text.ToString());
                thanhvien.MANV = pHIEUBAOHANHDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.MASP = pHIEUBAOHANHDataGridView.CurrentRow.Cells[3].Value.ToString();

                db.SubmitChanges();
                frm_BaoHanh_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }
        
        private void btn_thempbh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mapbh.Text == "" || txt_manv.Text == "" || txtmakh.Text == "" || txtMasp.Text == "" || dateEdit1.Text == "")
                {
                    MessageBox.Show("Không được để trống");
                    return;
                }
                var kt = from s in db.PHIEUBAOHANHs where s.MASP == txt_mapbh.Text select s;
                if (kt.Count() > 0)
                {
                    MessageBox.Show("Trùng khóa chính");
                    return;
                }
                PHIEUBAOHANH bb = new PHIEUBAOHANH();
                bb.MABH = txt_mapbh.Text;
                bb.MANV = txt_manv.Text;
                bb.MAKH = txtmakh.Text;
                bb.MASP = txtMasp.Text;
                bb.NGAYHETHANDOITRA = Convert.ToDateTime(dateEdit1.Text.ToString());        
                db.PHIEUBAOHANHs.InsertOnSubmit(bb);
                db.SubmitChanges();
                
                frm_BaoHanh_Load(sender, e);
                MessageBox.Show("thành công");
                
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void txt_tkpbh_TextChanged(object sender, EventArgs e)
        {
            pHIEUBAOHANHDataGridView.DataSource=db.XEMTT_PBH(txt_tkpbh.Text.ToString());
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
