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
    public partial class frm_ncc : Form
    {
        public frm_ncc()
        {
            InitializeComponent();
        }

        private void nHACCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void frm_ncc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.NHACC' table. You can move, or remove it, as needed.
            this.nHACCTableAdapter.Fill(this.dataSet_ShopGiay.NHACC);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nHACCDataGridView.DataSource = db.XEMTT_TTNCC(textBox1.Text.ToString());
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            NHACC ct = new NHACC();
            if (txtmancc.Text == "" || txtTenncc.Text == "" || txtemail.Text == "" || txtDiachi.Text == "" || txtSdtncc.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            var kt = from s in db.NHACCs where s.MANCC == txtmancc.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MANCC = txtmancc.Text;
            ct.TENNCC = txtTenncc.Text;
            ct.EMAIL = txtemail.Text;
            ct.DIACHINCC = txtDiachi.Text;
            ct.SDTNHACC = txtSdtncc.Text;
            db.NHACCs.InsertOnSubmit(ct);
            db.SubmitChanges();
            frm_ncc_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void nHACCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.NHACCs
                      where s.MANCC == nHACCDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            if (e.ColumnIndex == 5)
            {
                var ktt = (from n in db.NHACCs
                           from p in db.SANPHAMs
                           from pn in db.PHIEUNHAPs
                           from pd in db.PHIEUDATHANGNCCs
                           where n.MANCC == pn.MANCC && n.MANCC == p.MANCC && n.MANCC == pd.MANCC && n.MANCC == nHACCDataGridView.CurrentRow.Cells[0].Value.ToString()
                           select n).Count();
                if (ktt == 0)
                {
                    var thanhvien = db.NHACCs.SingleOrDefault(tv => tv.MANCC == nHACCDataGridView.CurrentRow.Cells[0].Value.ToString());
                    if (kt.Count() == 0)
                    {
                        return;
                    }
                    db.NHACCs.DeleteOnSubmit(thanhvien);
                    db.SubmitChanges();
                    frm_ncc_Load(sender, e);
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Không thể xóa");
                }
            }
            if (e.ColumnIndex == 6)
            {
                var thanhvien = db.NHACCs.SingleOrDefault(tv => tv.MANCC == nHACCDataGridView.CurrentRow.Cells[0].Value.ToString());

                thanhvien.SDTNHACC = nHACCDataGridView.CurrentRow.Cells[2].Value.ToString();
                thanhvien.EMAIL = nHACCDataGridView.CurrentRow.Cells[3].Value.ToString();
                thanhvien.DIACHINCC = nHACCDataGridView.CurrentRow.Cells[4].Value.ToString();
                db.SubmitChanges();
                frm_ncc_Load(sender, e);
                MessageBox.Show("Thành công");
            }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
