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
    public partial class QLSuCo : Form
    {
        public QLSuCo()
        {
            InitializeComponent();
        }

        private void QLSuCo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DMSUCO' table. You can move, or remove it, as needed.
            this.dMSUCOTableAdapter.Fill(this.dataSet_ShopGiay.DMSUCO);


        }

        private void dMSUCOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dMSUCOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btn_them_Click(object sender, EventArgs e)
        {
            DMSUCO ct = new DMSUCO();
            if (txtmasc.Text == "" || txttensc.Text == "" || txtphi.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
            var kt = from s in db.DMSUCOs where s.MASC == txtmasc.Text.ToString() select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("trùng khóa chính");
                return;
            }
            ct.MASC = txtmasc.Text;
            ct.TENSUCO = txttensc.Text;
            ct.SOTIEN = Convert.ToDecimal(txtphi.Text);
            db.DMSUCOs.InsertOnSubmit(ct);
            db.SubmitChanges();
            QLSuCo_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void dMSUCODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.DMSUCOs
                      where s.MASC == dMSUCODataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 3)
            {
                var ktt = (from bb in db.CTBBSCs
                           from d in db.DMSUCOs
                           where bb.MASC == d.MASC && d.MASC == dMSUCODataGridView.CurrentRow.Cells[0].Value.ToString()
                           select d).Count();
                if (ktt == 0)
                {
                    var thanhvien = db.DMSUCOs.SingleOrDefault(tv => tv.MASC == dMSUCODataGridView.CurrentRow.Cells[0].Value.ToString());
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.DMSUCOs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    QLSuCo_Load(sender, e);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("không thể xóa");
                }
            }
            if (e.ColumnIndex == 4)
            {
                var thanhvien = db.DMSUCOs.SingleOrDefault(tv => tv.MASC == dMSUCODataGridView.CurrentRow.Cells[0].Value.ToString());

                thanhvien.SOTIEN = Convert.ToDecimal(dMSUCODataGridView.CurrentRow.Cells[2].Value.ToString());
                db.SubmitChanges();
                QLSuCo_Load(sender, e);
                MessageBox.Show("Thành công");
            }
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
        int n;
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

    }
}
