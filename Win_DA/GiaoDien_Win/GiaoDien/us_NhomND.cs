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
    public partial class us_NhomND : UserControl
    {
        public us_NhomND()
        {
            InitializeComponent();
        }

        private void us_NhomND_Load(object sender, EventArgs e)
        {
            this.qLNHOMNDTableAdapter.Fill(this.dataSet_ShopGiay.QLNHOMND);
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtmanhom.Text == "" || txttennhom.Text == "" )
                {
                    MessageBox.Show("không được để trống");
                    return;
                }
                var kt = (from s in db.QLNHOMNDs
                          where s.MANHOM == txtmanhom.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    QLNHOMND qlnnd = new QLNHOMND();
                    qlnnd.MANHOM = txtmanhom.Text.ToString();
                    qlnnd.TENNHOMND = txttennhom.Text.ToString();
                    qlnnd.GHICHU = txtghichu.Text.ToString();
                    db.QLNHOMNDs.InsertOnSubmit(qlnnd);
                    db.SubmitChanges();

                    us_NhomND_Load(sender, e);
                    MessageBox.Show("thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void qLNHOMNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qLNHOMNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void qLNHOMNDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.QLNHOMNDs
                      where s.MANHOM == qLNHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            var thanhvien = db.QLNHOMNDs.SingleOrDefault(tv => tv.MANHOM == qLNHOMNDDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 3)
            {
               
                if (kt.Count() == 0)
                {
                    return;
                }
                db.QLNHOMNDs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                us_NhomND_Load(sender, e);
                MessageBox.Show("thành công");
            }
            if (e.ColumnIndex == 4)
            {
                
                if (kt.Count() == 0)
                {
                    return;
                }
                thanhvien.TENNHOMND = qLNHOMNDDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.GHICHU = qLNHOMNDDataGridView.CurrentRow.Cells[2].Value.ToString();
                db.SubmitChanges();
                us_NhomND_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void txt_tkhd_TextChanged(object sender, EventArgs e)
        {
            qLNHOMNDDataGridView.DataSource = db.XEM_NHOMND(txt_tkhd.Text);
        }

    }
}
