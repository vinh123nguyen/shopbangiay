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
    public partial class Them_CTHD : Form
    {
        public Them_CTHD(CTHD us)
        {
            InitializeComponent();
        }

        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }
         public delegate void updatedelegate(object sender, UpdateEventArgs args);
         public event updatedelegate UpdateEventHandler;


         public class UpdateEventArgs : EventArgs
         {
             public string data
             {
                 get;
                 set;
             }
         }
         protected void insert()
         {
             UpdateEventArgs args = new UpdateEventArgs();
             UpdateEventHandler.Invoke(this, args);
         }
        private void Them_CTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.dataSet_ShopGiay.KHUYENMAI);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SIZEGIAY' table. You can move, or remove it, as needed.
            this.sIZEGIAYTableAdapter.Fill(this.dataSet_ShopGiay.SIZEGIAY);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.dataSet_ShopGiay.SANPHAM);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.HOADONBAN' table. You can move, or remove it, as needed.
            this.hOADONBANTableAdapter.Fill(this.dataSet_ShopGiay.HOADONBAN);
            txtmabh.Text = db.SINHMA_PBH();
            txtmahd.Text=strNhan;
            txtmacthdb.Text = db.SINHMA_CTHDB();
        }
        
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETHOADONBAN bb = new CHITIETHOADONBAN();
                if (txtmacthdb.Text == "" || txtmahd.Text == "" || txtmasp.Text == "" || cbososize.Text == "" || txtmabh.Text == ""
                || kHUYENMAIComboBox.Text == "" || txtsl.Text == "" || txtdongia.Text == "")
                {
                    MessageBox.Show("không được để trống");
                    return;
                }
                var ktpbh = (
                          from ct in db.PHIEUBAOHANHs
                          where ct.MABH == txtmabh.Text.ToString()
                          select bb).Count();
                if (ktpbh == 0)
                {
                    frm_BaoHanh bh = new frm_BaoHanh();
                    bh.ShowDialog();
                }

                var kt = from s in db.CHITIETHOADONBANs where s.MACTHDB == txtmacthdb.Text select s;
                if (kt.Count() > 0)
                {
                    MessageBox.Show("Trùng khóa chính");
                    return;
                }
                bb.MACTHDB = txtmacthdb.Text;
                bb.MAHD = txtmahd.Text;
                bb.MASP = txtmasp.Text;
                bb.SOSIZE = Convert.ToInt16(cbososize.Text);
                bb.MABH = txtmabh.Text;
                bb.MAKM = kHUYENMAIComboBox.SelectedValue.ToString();
                bb.SOLUONGBAN = Convert.ToInt32(txtsl.Text);
                bb.DONGIABAN = Convert.ToDouble(txtdongia.Text);
                db.CHITIETHOADONBANs.InsertOnSubmit(bb);
                db.SubmitChanges();
                insert();
                MessageBox.Show("Thành công");
            }
            catch
            {
                return;
            }
           
        }

        private void hOADONBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtmasp_TextChanged(object sender, EventArgs e)
        {
            
        }
        //từ mã sp lấy ra màu sản phẩm
        private void txtmasp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SANPHAM bb = new SANPHAM();
                var ktpbh = (
                          from ct in db.SANPHAMs
                          where ct.MASP == txtmasp.Text.ToString()
                          select ct.MAU).FirstOrDefault();
             
                var kt = (
                          from ct in db.SANPHAMs
                          where ct.MASP == txtmasp.Text.ToString()
                          select ct.GIA).FirstOrDefault();
                var ktsosize = (from s in db.SIZEGIAYs where s.MASP == txtmasp.Text select s.SOSIZE).ToList();
                
                txt_mau.Text = ktpbh.ToString();
                txtdongia.Text = kt.ToString();
                cbososize.DataSource = ktsosize.ToList();
            }
            
        }

        private void txt_mau_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
       
    }
}
