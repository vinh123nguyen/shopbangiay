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
    public partial class frm_KhuyenMai : Form
    {
        public frm_KhuyenMai()
        {
            InitializeComponent();
        }

        private void cT_KHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
              this.cT_KHUYENMAIBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void frm_KhuyenMai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
            this.cT_KHUYENMAITableAdapter.Fill(this.dataSet_ShopGiay.CT_KHUYENMAI);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.dataSet_ShopGiay.KHUYENMAI);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CT_KHUYENMAI' table. You can move, or remove it, as needed.
            txtmakm.Text = db.SINHMA_KH();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txtmakm.Text == "" || txtnd.Text == "" || txtphantram.Text == "")
            {
                MessageBox.Show("không thể xóa");
                return;
            }
            KHUYENMAI ct = new KHUYENMAI();
            var kt = from s in db.KHUYENMAIs where s.MAKM == txtmakm.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MAKM = txtmakm.Text;
            ct.NOIDUNG = txtnd.Text;
            ct.PHANTRAM = Convert.ToDouble(txtphantram.Text);

            ct.APDUNG = aPDUNGCheckEdit.Checked;

            db.KHUYENMAIs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_KhuyenMai_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void kHUYENMAIDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.KHUYENMAIs
                      where s.MAKM == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });

            if (e.ColumnIndex == 4)
            {
                  var kttt = (from bb in db.KHUYENMAIs
                              from ct in db.CT_KHUYENMAIs
                              from cthd in db.CHITIETHOADONBANs
                              where bb.MAKM == ct.MAKM && bb.MAKM == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString() || bb.MAKM == cthd.MAKM && bb.MAKM == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                  if (kttt == 0)
                  {
                      var thanhvien = db.KHUYENMAIs.SingleOrDefault(tv => tv.MAKM == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                      if (kt.Count() == 0)
                      {
                          return;
                      }
                      db.KHUYENMAIs.DeleteOnSubmit(thanhvien);
                      db.SubmitChanges();
                      frm_KhuyenMai_Load(sender, e);
                      MessageBox.Show("Thành công");
                  }
                  else
                  {
                      MessageBox.Show("không thể xóa");
                  }
            }
            if (e.ColumnIndex == 5)
            {
                var thanhvien = db.KHUYENMAIs.SingleOrDefault(tv => tv.MAKM == kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                thanhvien.NOIDUNG = kHUYENMAIDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.PHANTRAM = Convert.ToDouble(kHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString());

                thanhvien.APDUNG = aPDUNGCheckEdit.Checked;
                db.SubmitChanges();
                frm_KhuyenMai_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (txtmakm.Text == "" || txtmasp.Text == "" || dateNBD.Text == "" || dateNKT.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
            CT_KHUYENMAI ct = new CT_KHUYENMAI();
            var kt = from s in db.CT_KHUYENMAIs where s.MAKM == txtmakm.Text && s.MASP == txtmasp.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MAKM = txtmakm_ct.Text;
            ct.MASP = txtmasp.Text;
            ct.NBD = Convert.ToDateTime(dateNBD.Text);
            ct.NKT = Convert.ToDateTime(dateNKT.Text);
            db.CT_KHUYENMAIs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_KhuyenMai_Load(sender, e);
            MessageBox.Show("thành công");
        }

        
        private void cT_KHUYENMAIDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.CT_KHUYENMAIs
                      where s.MAKM == cT_KHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 4)
            {

                var thanhvien = db.CT_KHUYENMAIs.SingleOrDefault(tv => tv.MAKM == cT_KHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == cT_KHUYENMAIDataGridView.CurrentRow.Cells[1].Value.ToString() && tv.NBD == Convert.ToDateTime(cT_KHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString()));
                if (kt.Count() == 0)
                {
                    return;
                }
                db.CT_KHUYENMAIs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_KhuyenMai_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 5)
            {
                var thanhvien = db.CT_KHUYENMAIs.SingleOrDefault(tv => tv.MAKM == cT_KHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASP == cT_KHUYENMAIDataGridView.CurrentRow.Cells[1].Value.ToString() && tv.NBD == Convert.ToDateTime(cT_KHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString()));

                thanhvien.NKT = Convert.ToDateTime(cT_KHUYENMAIDataGridView.CurrentRow.Cells[3].Value.ToString());

                db.SubmitChanges();
                frm_KhuyenMai_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }

        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {
            kHUYENMAIDataGridView.DataSource = db.XEMTT_KHUYENMAI(textBoxX4.Text.ToString());
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            cT_KHUYENMAIDataGridView.DataSource = db.XEMTT_CTKHUYENMAI(textBoxX1.Text.ToString());
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
