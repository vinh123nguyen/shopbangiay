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
    public partial class BBSuCo : Form
    {
        public BBSuCo()
        {
            InitializeComponent();
        }
       
        private void bIENBANSUCOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bIENBANSUCOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);
        }

        private void BBSuCo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DMSUCO' table. You can move, or remove it, as needed.
            this.dMSUCOTableAdapter.Fill(this.dataSet_ShopGiay.DMSUCO);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CTBBSC' table. You can move, or remove it, as needed.
            this.cTBBSCTableAdapter.Fill(this.dataSet_ShopGiay.CTBBSC);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.BIENBANSUCO' table. You can move, or remove it, as needed.
            this.bIENBANSUCOTableAdapter.Fill(this.dataSet_ShopGiay.BIENBANSUCO);
            txt_mabbsc.Text = db.SINHMA_BBSC();
        }
       
        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
        //Thêm 
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txt_mabbsc.Text == "" || txt_manv.Text == "" || txt_ghichu.Text =="" || txtNgaylap.Text=="")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            //kiểm tra trùng
            BIENBANSUCO bb = new BIENBANSUCO();
            var kt = from s in db.BIENBANSUCOs where s.MABB == txt_mabbsc.Text  select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            bb.MABB = txt_mabbsc.Text;
            bb.MANV = txt_manv.Text;
            bb.GHICHU = txt_ghichu.Text;
            bb.NGAYLAPBB = Convert.ToDateTime(txtNgaylap.Text.ToString());//Convert về đúng kểu trong cơ sở dl

            db.BIENBANSUCOs.InsertOnSubmit(bb);
            db.SubmitChanges();
            BBSuCo_Load(sender, e);
            MessageBox.Show("Thành công");

        }
        //xóa trong datagridview
        private void bIENBANSUCODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.ColumnIndex == 4)// stt cột trong datagirdview
                {
                  //kiểm tra có khóa ngoại
                    var kt = (from bb in db.BIENBANSUCOs
                              from ct in db.CTBBSCs where bb.MABB == ct.MABB && bb.MABB==bIENBANSUCODataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                    var kt1 = (from bb in db.BIENBANSUCOs
                              from cttksc in db.CTTKSCs
                              where cttksc.MABB == bb.MABB && bb.MABB == bIENBANSUCODataGridView.CurrentRow.Cells[0].Value.ToString()
                              select bb).Count();
                    if (kt == 0 && kt1==0)
                    {
                        var thanhvien = db.BIENBANSUCOs.SingleOrDefault(tv => tv.MABB == bIENBANSUCODataGridView.CurrentRow.Cells[0].Value.ToString());
                        db.BIENBANSUCOs.DeleteOnSubmit(thanhvien);

                        db.SubmitChanges();
                        BBSuCo_Load(sender, e);
                        MessageBox.Show("thành công");

                    }
                    else
                    {
                        MessageBox.Show("không thể xóa");
                    }

                }
            //sửa
                if (e.ColumnIndex == 5)
                {
                    var thanhvien = db.BIENBANSUCOs.SingleOrDefault(tv => tv.MABB == bIENBANSUCODataGridView.CurrentRow.Cells[0].Value.ToString());
                    thanhvien.MANV = bIENBANSUCODataGridView.CurrentRow.Cells[1].Value.ToString();
                    thanhvien.GHICHU = bIENBANSUCODataGridView.CurrentRow.Cells[2].Value.ToString();
                    thanhvien.NGAYLAPBB = Convert.ToDateTime(bIENBANSUCODataGridView.CurrentRow.Cells[3].Value.ToString());
                    db.SubmitChanges();
                    BBSuCo_Load(sender, e);
                    MessageBox.Show("thành công");
                }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(mABBTextEdit.Text==string.Empty || dMSUCOComboBox.Text==string.Empty || txt_ChiNhapSo.Text==string.Empty)
            {
                MessageBox.Show("không được để trống");
                return;
            }
            CTBBSC ct = new CTBBSC();
            var kt = from s in db.CTBBSCs where s.MABB == mABBTextEdit.Text && s.MASC == dMSUCOComboBox.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            ct.MABB = mABBTextEdit.Text;
            ct.MASC = dMSUCOComboBox.Text;
            ct.THU_CHI = Convert.ToDecimal(txt_ChiNhapSo.Text.ToString());
            db.CTBBSCs.InsertOnSubmit(ct);
            db.SubmitChanges();
            BBSuCo_Load(sender, e);
            MessageBox.Show("thành công");
        }

        private void cTBBSCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {

                var thanhvien = db.CTBBSCs.SingleOrDefault(tv => tv.MABB == cTBBSCDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASC == cTBBSCDataGridView.CurrentRow.Cells[1].Value.ToString());
                db.CTBBSCs.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                BBSuCo_Load(sender, e);
            }
            if (e.ColumnIndex == 4)
            {
                var thanhvien = db.CTBBSCs.SingleOrDefault(tv => tv.MABB == cTBBSCDataGridView.CurrentRow.Cells[0].Value.ToString() && tv.MASC == cTBBSCDataGridView.CurrentRow.Cells[1].Value.ToString());
                thanhvien.THU_CHI = Convert.ToDecimal(cTBBSCDataGridView.CurrentRow.Cells[2].Value.ToString());
                db.SubmitChanges();
                BBSuCo_Load(sender, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int n = 0;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                n= 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                n = 0;
            }

            
        }

        private void txt_tkhd_TextChanged(object sender, EventArgs e)
        {
            bIENBANSUCODataGridView.DataSource = db.XEMTT_BBSC(txt_tkhd.Text.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cTBBSCDataGridView.DataSource = db.XEMTT_CTBBSC(textBox1.Text.ToString());
        }
        int newLocationX, newLocationY;
        private void BBSuCo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void BBSuCo_MouseMove(object sender, MouseEventArgs e)
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
