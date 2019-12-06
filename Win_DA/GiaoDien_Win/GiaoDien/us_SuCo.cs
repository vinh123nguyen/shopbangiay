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
    public partial class us_SuCo : UserControl
    {
        public us_SuCo()
        {
            InitializeComponent();
        }

        private void bIENBANSUCOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {
            
        }

      
        private void us_SuCo_Load(object sender, EventArgs e)
        {
            this.dMTKTableAdapter.Fill(this.dataSet_ShopGiay.DMTK); 
            this.tHONGKE_SCTableAdapter.Fill(this.dataSet_ShopGiay.THONGKE_SC);
            this.cTTKSCTableAdapter.Fill(this.dataSet_ShopGiay.CTTKSC);
            txt_mtk.Text = db.SINHMA_TK();
            txt_macttksc.Text = txt_mtk.Text.ToString();
        }

      

        private void tHONGKE_SCBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tHONGKE_SCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.THONGKE_SCs
                          where s.MADMTK== txt_mtk.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    THONGKE_SC tksc = new THONGKE_SC();
                    tksc.MATKSC = txt_mtk.Text.ToString();
                    tksc.MANV = txt_manv.Text.ToString();
                    tksc.MADMTK = dMTKComboBox.SelectedValue.ToString();
                    tksc.NGAYLAPTK = Convert.ToDateTime(nl.Text.ToString());
                    tksc.TONGSOSC = Convert.ToInt32(db.TONGSOSC_frmtksc(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                    tksc.TONGTHU_CHI = Convert.ToDecimal(db.tongthuchisc(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                    db.THONGKE_SCs.InsertOnSubmit(tksc);
                    db.SubmitChanges();
                    this.tHONGKE_SCTableAdapter.Fill(this.dataSet_ShopGiay.THONGKE_SC);
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.CTTKSCs
                          where s.MATKSC == txt_macttksc.Text.ToString() && s.MABB==txt_mbb.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    CTTKSC cttksc = new CTTKSC();
                    cttksc.MATKSC = txt_macttksc.Text.ToString();
                    cttksc.MABB = txt_mbb.Text.ToString();
                    cttksc.THU_CHI = Convert.ToDecimal(db.tongthuchicttksc(txt_mbb.Text.ToString(),Convert.ToDateTime(tungay1.Text.ToString()), Convert.ToDateTime(denngay1.Text.ToString())));
                
                    db.CTTKSCs.InsertOnSubmit(cttksc);
                    db.SubmitChanges();
                    us_SuCo_Load(sender,e);
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

        private void tHONGKE_SCDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var kt = (from s in db.THONGKE_SCs
                          where s.MATKSC == tHONGKE_SCDataGridView1.CurrentRow.Cells[0].Value.ToString()
                          select new
                          {
                              s
                          });
                var thanhvien = db.THONGKE_SCs.SingleOrDefault(tv => tv.MATKSC == tHONGKE_SCDataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (e.ColumnIndex == 6)
                {

                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.THONGKE_SCs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    us_SuCo_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                if (e.ColumnIndex == 7)
                {
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    thanhvien.MANV = tHONGKE_SCDataGridView1.CurrentRow.Cells[1].Value.ToString();
                    thanhvien.MADMTK = tHONGKE_SCDataGridView1.CurrentRow.Cells[2].Value.ToString();
                    thanhvien.NGAYLAPTK = Convert.ToDateTime(tHONGKE_SCDataGridView1.CurrentRow.Cells[3].Value.ToString());
                    thanhvien.TONGSOSC = Convert.ToInt32(tHONGKE_SCDataGridView1.CurrentRow.Cells[4].Value.ToString());
                    thanhvien.TONGTHU_CHI = Convert.ToDecimal(tHONGKE_SCDataGridView1.CurrentRow.Cells[5].Value.ToString());
                    db.SubmitChanges();
                    us_SuCo_Load(sender, e);
                    MessageBox.Show("thành công");
                }
            }
            catch
            {
                MessageBox.Show("xảy ra lỗi");
            }
        }

        private void cTTKSCDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                var kt = (from s in db.CTTKSCs
                          where s.MATKSC == cTTKSCDataGridView1.CurrentRow.Cells[0].Value.ToString() && s.MABB == cTTKSCDataGridView1.CurrentRow.Cells[1].Value.ToString()
                          select new
                          {
                              s
                          });
                var thanhvien = db.CTTKSCs.SingleOrDefault(tv => tv.MATKSC == cTTKSCDataGridView1.CurrentRow.Cells[0].Value.ToString() && tv.MABB == cTTKSCDataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (e.ColumnIndex == 3)
                {

                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.CTTKSCs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    us_SuCo_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                if (e.ColumnIndex == 4)
                {
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    thanhvien.MABB = cTTKSCDataGridView1.CurrentRow.Cells[1].Value.ToString();
                    thanhvien.THU_CHI = Convert.ToDecimal(cTTKSCDataGridView1.CurrentRow.Cells[2].Value.ToString());
                    db.SubmitChanges();
                    us_SuCo_Load(sender, e);
                    MessageBox.Show("thành công");
                }
           
        }
    }
}
