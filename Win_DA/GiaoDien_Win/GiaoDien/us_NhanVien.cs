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
    public partial class us_NhanVien : UserControl
    {
        public us_NhanVien()
        {
            InitializeComponent();
        }
        private void F2_UpdateEventHandler(object sender, Them_NV.UpdateEventArgs args)
        {
            this.nHANVIENTableAdapter.Fill(this.dataSet_ShopGiay.NHANVIEN);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Them_NV nv = new Them_NV(this);
            nv.UpdateEventHandler += F2_UpdateEventHandler;
            nv.ShowDialog();
           
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void us_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHITIETPHIEUNHAP' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataSet_ShopGiay.NHANVIEN);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.NHANVIENs
                          where s.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString()
                          select new
                          {
                              s
                          });
                var thanhvien = db.NHANVIENs.SingleOrDefault(tv => tv.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (kt.Count() == 0)
                {
                    MessageBox.Show("giá trị không tồn tại");
                    return;
                }
                db.NHANVIENs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                us_NhanVien_Load(sender, e);
                MessageBox.Show("thành công");
            }
            catch
            {
                MessageBox.Show("xảy ra lỗi");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.NHANVIENs
                          where s.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString()
                          select new
                          {
                              s
                          });
                var thanhvien = db.NHANVIENs.SingleOrDefault(tv => tv.MANV == nHANVIENDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (kt.Count() == 0)
                {
                    MessageBox.Show("giá trị không tồn tại");
                    return;
                }

                thanhvien.TENNV = nHANVIENDataGridView.CurrentRow.Cells[1].Value.ToString();
                thanhvien.GIOITINH = nHANVIENDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.SOCMND = Convert.ToInt32(nHANVIENDataGridView.CurrentRow.Cells[3].Value.ToString());
                thanhvien.DIENTHOAINV = Convert.ToInt32(nHANVIENDataGridView.CurrentRow.Cells[4].Value.ToString());
                thanhvien.DIACHI = nHANVIENDataGridView.CurrentRow.Cells[5].Value.ToString();
                thanhvien.MACHUCVU = nHANVIENDataGridView.CurrentRow.Cells[6].Value.ToString();
                thanhvien.TINHTRANG = nHANVIENDataGridView.CurrentRow.Cells[7].Value.ToString();
                thanhvien.NGAYVAOLAM = Convert.ToDateTime(nHANVIENDataGridView.CurrentRow.Cells[8].Value.ToString());
                thanhvien.MANQL = nHANVIENDataGridView.CurrentRow.Cells[9].Value.ToString();
                thanhvien.THUONGDOANHTHU = Convert.ToDouble(nHANVIENDataGridView.CurrentRow.Cells[10].Value.ToString());
                thanhvien.LUONGTRU = Convert.ToDouble(nHANVIENDataGridView.CurrentRow.Cells[11].Value.ToString());
                thanhvien.THUCLANH = Convert.ToDouble(nHANVIENDataGridView.CurrentRow.Cells[12].Value.ToString());
                db.SubmitChanges();
                us_NhanVien_Load(sender, e);
                MessageBox.Show("thành công");
            }
            catch
            {
                MessageBox.Show("xảy ra lỗi");
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            nHANVIENDataGridView.DataSource = db.XEMTT_TTNHANVIEN(txttimkiem.Text.ToString());
        }
        

     
    }
}
