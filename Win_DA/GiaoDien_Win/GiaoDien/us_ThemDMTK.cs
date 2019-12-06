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
    public partial class us_ThemDMTK : UserControl
    {
        public us_ThemDMTK()
        {
            InitializeComponent();
        }

        private void dMTKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dMTKBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void us_ThemDMTK_Load(object sender, EventArgs e)
        {
            this.dMTKTableAdapter.Fill(this.dataSet_ShopGiay.DMTK);
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.DMTKs
                          where s.MADMTK == txtdanhmuc.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    DMTK dmtk = new DMTK();
                    dmtk.MADMTK = txtdanhmuc.Text.ToString();
                    dmtk.LOAITHONGKE = txtloaitk.Text.ToString();
                    
                    db.DMTKs.InsertOnSubmit(dmtk);
                    db.SubmitChanges();
                    us_ThemDMTK_Load(sender, e);
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

        private void dMTKDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.DMTKs
                      where s.MADMTK == dMTKDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            var thanhvien = db.DMTKs.SingleOrDefault(tv => tv.MADMTK == dMTKDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 2)
            {

                if (kt.Count() == 0)
                {
                    return;
                }
                db.DMTKs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                us_ThemDMTK_Load(sender, e);
                MessageBox.Show("thành công");
            }
            if (e.ColumnIndex == 3)
            {

                if (kt.Count() == 0)
                {
                    return;
                }
                thanhvien.LOAITHONGKE = dMTKDataGridView.CurrentRow.Cells[1].Value.ToString();
                
                db.SubmitChanges();
                us_ThemDMTK_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }
    }
}
