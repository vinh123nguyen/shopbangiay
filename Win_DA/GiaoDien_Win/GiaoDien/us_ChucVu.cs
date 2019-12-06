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
    public partial class us_ChucVu : UserControl
    {
        public us_ChucVu()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();

        private void us_ChucVu_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet_ShopGiay.CHUCVU);

        }

        private void cHUCVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHUCVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cHUCVUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
                var kt = (from s in db.CHUCVUs
                          where s.MACHUCVU == cHUCVUDataGridView.CurrentRow.Cells[0].Value.ToString()
                          select new
                          {
                              s
                          });
           // var thanhvien = db.CHUCVUs.SingleOrDefault(tv => tv.MACHUCVU == cHUCVUDataGridView.CurrentRow.Cells[0].Value.ToString());
            CHUCVU cv;
            cv = db.CHUCVUs.Where(p => p.MACHUCVU.Equals( cHUCVUDataGridView.CurrentRow.Cells[0].Value.ToString())).SingleOrDefault();
                if (e.ColumnIndex == 3)
                {
                    
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.CHUCVUs.DeleteOnSubmit(cv);
                    db.SubmitChanges();
                    us_ChucVu_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                if (e.ColumnIndex == 4)
                {
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    cv.TENCV = cHUCVUDataGridView.CurrentRow.Cells[1].Value.ToString();
                    cv.LUONG = Convert.ToDouble(cHUCVUDataGridView.CurrentRow.Cells[2].Value.ToString());
                    db.SubmitChanges();
                    us_ChucVu_Load(sender, e);
                    MessageBox.Show("thành công");
                }

        }
       
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmacv.Text == "" || txttencv.Text == "" || txtluong.Text == "" )
                {
                    MessageBox.Show("không được để trống");
                    return;
                }
                var kt = (from s in db.CHUCVUs
                          where s.MACHUCVU == txtmacv.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    CHUCVU cv = new CHUCVU();
                    cv.MACHUCVU = txtmacv.Text.ToString();
                    cv.TENCV = txttencv.Text.ToString();
                    cv.LUONG = Convert.ToDouble(txtluong.Text.ToString());
                    db.CHUCVUs.InsertOnSubmit(cv);
                    db.SubmitChanges();

                    us_ChucVu_Load(sender, e);
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

        private void txttikiem_TextChanged(object sender, EventArgs e)
        {
            cHUCVUDataGridView.DataSource = db.XEMTT_TTCHUCVU(txttikiem.Text);
        }
    }
}
