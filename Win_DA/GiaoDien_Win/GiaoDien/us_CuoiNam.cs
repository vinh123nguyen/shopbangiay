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
    public partial class us_CuoiNam : UserControl
    {
        public us_CuoiNam()
        {
            InitializeComponent();
        }

        private void tHONGKE_CUOINAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHONGKE_CUOINAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void us_CuoiNam_Load(object sender, EventArgs e)
        {
            this.tHONGKE_CUOINAMTableAdapter.Fill(this.dataSet_ShopGiay.THONGKE_CUOINAM);
            this.dMTKTableAdapter.Fill(this.dataSet_ShopGiay.DMTK);
            txt_mtkcn.Text = db.SINHMA_TK();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void tHONGKE_CUOINAMDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.THONGKE_CUOINAMs
                      where s.MATKCN == tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            var thanhvien = db.THONGKE_CUOINAMs.SingleOrDefault(tv => tv.MATKCN == tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 5)
            {

                if (kt.Count() == 0)
                {
                    return;
                }
                db.THONGKE_CUOINAMs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                us_CuoiNam_Load(sender, e);
                MessageBox.Show("thành công");
            }
            if (e.ColumnIndex == 6)
            {

                if (kt.Count() == 0)
                {
                    return;
                }
                thanhvien.MANV = tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.MADMTK = tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.NGAYLAPTK=Convert.ToDateTime(tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.TONGTIENDS_CN = Convert.ToDecimal(tHONGKE_CUOINAMDataGridView.CurrentRow.Cells[4].Value.ToString());
                db.SubmitChanges();
                us_CuoiNam_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mtkcn.Text == "" || txtnhanvien.Text == "" || dMTKComboBox.Text == "" || nl.Text=="")
                {
                    MessageBox.Show("không được để trống");
                    return;
                }
                var kt = (from s in db.THONGKE_CUOINAMs
                          where s.MATKCN == txt_mtkcn.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    THONGKE_CUOINAM tkcn = new THONGKE_CUOINAM();
                    tkcn.MATKCN = txt_mtkcn.Text.ToString();
                    tkcn.MANV = txtnhanvien.Text.ToString();
                    tkcn.MADMTK = dMTKComboBox.SelectedValue.ToString();
                    tkcn.NGAYLAPTK = Convert.ToDateTime(nl.Text.ToString());
                    tkcn.TONGTIENDS_CN = Convert.ToDecimal(db.rongthucuoinam(Convert.ToDateTime(dateTimeInput_ngay.Text.ToString()), Convert.ToDateTime(dateTimeInput2.Text.ToString())));

                    db.THONGKE_CUOINAMs.InsertOnSubmit(tkcn);
                    db.SubmitChanges();
                    us_CuoiNam_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("trùng khóa chính");
                }
            }
            catch
            {
                MessageBox.Show("xay ra loi");
            }
        } 
    }
}
