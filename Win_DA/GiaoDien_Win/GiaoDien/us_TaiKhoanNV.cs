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
    public partial class us_TaiKhoanNV : UserControl
    {
        public us_TaiKhoanNV()
        {
            InitializeComponent();
        }

        private void qUANLYNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qUANLYNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }


        private void us_TaiKhoanNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.qUANLYNDTableAdapter.Fill(this.dataSet_ShopGiay.QUANLYND);
        }
        DataClasses2DataContext db=new DataClasses2DataContext();
        private void qUANLYNDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.QUANLYNDs
                      where s.TENDN == qUANLYNDDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            var thanhvien = db.QUANLYNDs.SingleOrDefault(tv => tv.TENDN == qUANLYNDDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 3)
            {
                
                if (kt.Count() == 0)
                {
                    return;
                }
                if (Convert.ToBoolean(qUANLYNDDataGridView.CurrentRow.Cells[2].Value.ToString()) == false)
                {
                    db.QUANLYNDs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    us_TaiKhoanNV_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("hãy đảm bảo tài khoản này đã ngưng hoạt động");
                }
            }
            if (e.ColumnIndex == 4)
            {
               
                if (kt.Count() == 0)
                {
                    return;
                }
                thanhvien.MK = qUANLYNDDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.HOATDONG = Convert.ToBoolean(qUANLYNDDataGridView.CurrentRow.Cells[2].Value.ToString());
                db.SubmitChanges();
                us_TaiKhoanNV_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.QUANLYNDs
                          where s.TENDN == txttendn.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    QUANLYND qlnd = new QUANLYND();
                    qlnd.TENDN = txttendn.Text.ToString();
                    qlnd.MK = txtmk.Text.ToString();
                    if (rdb_hd.Checked == true)
                    {
                        qlnd.HOATDONG = Convert.ToBoolean(true);
                    }
                    else
                    {
                        if (rdb_khd.Checked == true)
                        {
                            qlnd.HOATDONG = Convert.ToBoolean(false);
                        }
                    }
                    db.QUANLYNDs.InsertOnSubmit(qlnd);
                    db.SubmitChanges();

                    us_TaiKhoanNV_Load(sender, e);
                    MessageBox.Show("thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {
            qUANLYNDDataGridView.DataSource = db.XEMTT_TTTAIKHOANNV(textBoxX4.Text);
        }
    }
}
