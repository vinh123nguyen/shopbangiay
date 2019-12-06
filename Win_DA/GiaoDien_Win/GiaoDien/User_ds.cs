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
    public partial class User_ds : UserControl
    {
        public User_ds()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxX1_MouseEnter(object sender, EventArgs e)
        {

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void User_ds_Load(object sender, EventArgs e)
        {
            this.dMTKTableAdapter.Fill(this.dataSet_ShopGiay.DMTK);
            this.tHONGKE_DSTableAdapter.Fill(this.dataSet_ShopGiay.THONGKE_DS);
            this.cTTKDSTableAdapter.Fill(this.dataSet_ShopGiay.CTTKDS);
            this.lOAIGIAYTableAdapter.Fill(this.dataSet_ShopGiay.LOAIGIAY);
            txttimctds.ForeColor = Color.Gray;
            txttimctds.Text = "Tìm kiếm theo mã";
            txtmatkds.Text = db.SINHMA_TK();
            txtmads.Text = txtmatkds.Text.ToString();
            this.txttimctds.Leave += textBoxX1_Leave;
            this.txttimctds.Enter += textBoxX1_Enter;
        }

        void textBoxX1_Enter(object sender, EventArgs e)
        {
            if (txttimctds.Text == "Tìm kiếm theo mã")
            {
                txttimctds.Text = "";
                txttimctds.ForeColor = Color.Gray;
            }
        }

        void textBoxX1_Leave(object sender, EventArgs e)
        {

            if (txttimctds.Text == "")
            {
                txttimctds.Text = "Tìm kiếm theo mã";
                txttimctds.ForeColor = Color.Gray;
            }
        }

        private void tHONGKE_DSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHONGKE_DSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);
           

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                var kt = (from s in db.THONGKE_Ds
                          where s.MATKDS == txtmatkds.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    THONGKE_D tkds = new THONGKE_D();
                    tkds.MATKDS = txtmatkds.Text.ToString();
                    tkds.MANV = txtnhanvien.Text.ToString();
                    tkds.MADMTK = dMTKComboBox.SelectedValue.ToString();
                    tkds.NGAYLAPTK = Convert.ToDateTime(nltk.Text.ToString());
                    tkds.TONGSODS = Convert.ToInt32(db.tongdoanhso(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                    tkds.TONGTIENDS = Convert.ToDecimal(db.tongdoanhthu(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                    db.THONGKE_Ds.InsertOnSubmit(tkds);
                    db.SubmitChanges();
                    this.tHONGKE_DSTableAdapter.Fill(this.dataSet_ShopGiay.THONGKE_DS);
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

        private void tHONGKE_DSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kt = (from s in db.THONGKE_Ds
                      where s.MATKDS == tHONGKE_DSDataGridView.CurrentRow.Cells[0].Value.ToString()
                      select new
                      {
                          s
                      });
            var thanhvien = db.THONGKE_Ds.SingleOrDefault(tv => tv.MATKDS == tHONGKE_DSDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 6)
            {

                if (kt.Count() == 0)
                {
                    return;
                }
                db.THONGKE_Ds.DeleteOnSubmit(thanhvien);
                db.SubmitChanges();
                User_ds_Load(sender, e);
                MessageBox.Show("thành công");
            }
            if (e.ColumnIndex == 7)
            {
                if (kt.Count() == 0)
                {
                    return;
                }
                thanhvien.MANV = txtnhanvien.Text.ToString();
                thanhvien.MADMTK = dMTKComboBox.SelectedValue.ToString();
                thanhvien.NGAYLAPTK = Convert.ToDateTime(nltk.Text.ToString());
                thanhvien.TONGSODS = Convert.ToInt32(db.tongdoanhso(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                thanhvien.TONGTIENDS = Convert.ToDecimal(db.tongdoanhso(Convert.ToDateTime(tungay.Text.ToString()), Convert.ToDateTime(denngay.Text.ToString())));
                db.SubmitChanges();
                User_ds_Load(sender, e);
                MessageBox.Show("thành công");
            }
        }

        private void btnThemctds_Click(object sender, EventArgs e)
        {
           
                var kt = (from s in db.CTTKDs
                          where s.MATKDS == txtmads.Text.ToString() && s.MASP==txtsanpham.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    CTTKD cttkds = new CTTKD();
                    cttkds.MATKDS = txtmads.Text.ToString();
                    cttkds.MASP = txtsanpham.Text.ToString();
                    var f = (from s in db.SANPHAMs
                             where s.MASP == txtsanpham.Text.ToString()
                             select s.MALOAI).SingleOrDefault().ToString();
                    var g = (from s in db.LOAIGIAYs
                             where s.MALOAI == f
                             select 
                                 s.MALOAI).SingleOrDefault().ToString();
                    MessageBox.Show(g);
                    cttkds.MALOAI = g;
                    cttkds.TIEN = Convert.ToDecimal(db.tiencttkds(txtsanpham.Text.ToString(), Convert.ToDateTime(tungayds.Text.ToString()), Convert.ToDateTime(denngayds.Text.ToString())).ToString());
                    db.CTTKDs.InsertOnSubmit(cttkds);
                    db.SubmitChanges();

                    User_ds_Load(sender, e);
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show("trùng khóa chính");
                }
            
            
        }

        private void dMTKComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dMTKComboBox_TextChanged(object sender, EventArgs e)
        {
            txt_mltk.Text = dMTKComboBox.SelectedValue.ToString();
        }


    
      

    }
}
