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
    public partial class frm_QLPhanQuyen : Form
    {
        public frm_QLPhanQuyen()
        {
            InitializeComponent();
        }

        private void qLPHANQUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qLPHANQUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void frm_QLPhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DMMANHINH' table. You can move, or remove it, as needed.
            this.dMMANHINHTableAdapter.Fill(this.dataSet_ShopGiay.DMMANHINH);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.QLNHOMND' table. You can move, or remove it, as needed.
            this.qLNHOMNDTableAdapter.Fill(this.dataSet_ShopGiay.QLNHOMND);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.QLPHANQUYEN' table. You can move, or remove it, as needed.
            this.qLPHANQUYENTableAdapter.Fill(this.dataSet_ShopGiay.QLPHANQUYEN);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cboMaMH.Text == "" || cboMaNhom.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            QLPHANQUYEN ct = new QLPHANQUYEN();
            var kt = from s in db.QLPHANQUYENs where s.MANHOM == cboMaNhom.Text && s.MAMANHINH == cboMaMH.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MANHOM = cboMaNhom.Text;
            ct.MAMANHINH = cboMaMH.Text;
            ct.COQUYEN = txtCoquyen.Text;
            db.QLPHANQUYENs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_QLPhanQuyen_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void qLPHANQUYENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.QLPHANQUYENs
                      where s.MANHOM == qLPHANQUYENDataGridView.CurrentRow.Cells[0].Value.ToString() && s.MAMANHINH == qLPHANQUYENDataGridView.CurrentRow.Cells[1].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 3)
            {

                var thanhvien = db.QLPHANQUYENs.SingleOrDefault(tv => tv.MANHOM == qLPHANQUYENDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MAMANHINH == qLPHANQUYENDataGridView.CurrentRow.Cells[1].Value.ToString());
                if (kt.Count() == 0)
                {
                    return;
                }
                db.QLPHANQUYENs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                frm_QLPhanQuyen_Load(sender, e);
                MessageBox.Show("Thành công");
            }
            if (e.ColumnIndex == 4)
            {
                var thanhvien = db.QLPHANQUYENs.SingleOrDefault(tv => tv.MANHOM == qLPHANQUYENDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MAMANHINH == qLPHANQUYENDataGridView.CurrentRow.Cells[1].Value.ToString());

                thanhvien.COQUYEN = qLPHANQUYENDataGridView.CurrentRow.Cells[2].Value.ToString();
                db.SubmitChanges();
                frm_QLPhanQuyen_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        }
    }
}
