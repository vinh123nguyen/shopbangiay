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
    public partial class frm_dmsp : Form
    {
        public frm_dmsp()
        {
            InitializeComponent();
        }

        private void dANHMUCSPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dANHMUCSPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void frm_dmsp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DANHMUCSP' table. You can move, or remove it, as needed.
            this.dANHMUCSPTableAdapter.Fill(this.dataSet_ShopGiay.DANHMUCSP);
            txt_madm.Text = db.SINHMA_DMSP();

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_madm.Text == "" || txt_tendm.Text == "")
            {
                MessageBox.Show("không được để trống");
                return;
            }
             DANHMUCSP bb = new DANHMUCSP();
            var kt = from s in db.DANHMUCSPs where s.MADMSP==txt_madm.Text.ToString() select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
               
                bb.MADMSP = txt_madm.Text;
                bb.TENDMSP = txt_tendm.Text;
                db.DANHMUCSPs.InsertOnSubmit(bb);
                db.SubmitChanges();
                frm_dmsp_Load(sender, e);
                MessageBox.Show("Thành công");
                txt_madm .Text= txt_tendm.Text = "";

         
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                 var kt = (from bb in db.DANHMUCSPs
                              from ct in db.SANPHAMs
                           from k in  db.KHOs where bb.MADMSP == ct.MADMSP &&bb.MADMSP==k.MADMSP && bb.MADMSP==dANHMUCSPDataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                 if (kt == 0)
                 {
                     var thanhvien = db.DANHMUCSPs.SingleOrDefault(tv => tv.MADMSP == dANHMUCSPDataGridView.CurrentRow.Cells[0].Value.ToString());
                     db.DANHMUCSPs.DeleteOnSubmit(thanhvien);
                     db.SubmitChanges();
                     frm_dmsp_Load(sender, e);
                     MessageBox.Show("thành công");
                 }
                 else
                 {
                     MessageBox.Show("không thể xóa");
                 }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var thanhvien = db.DANHMUCSPs.SingleOrDefault(tv => tv.MADMSP == dANHMUCSPDataGridView.CurrentRow.Cells[0].Value.ToString());
            
            thanhvien.TENDMSP = dANHMUCSPDataGridView.CurrentRow.Cells[1].Value.ToString();
            db.SubmitChanges();
            frm_dmsp_Load(sender, e);
            MessageBox.Show("thành công");
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
