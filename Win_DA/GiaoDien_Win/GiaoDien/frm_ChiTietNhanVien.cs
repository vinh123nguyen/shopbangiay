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
    public partial class frm_ChiTietNhanVien : Form
    {
       public frm_ChiTietNhanVien()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }
        string strNhan;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void frm_ChiTietNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet_ShopGiay.CHUCVU);
            textBox3.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.MANV).SingleOrDefault().ToString();
            textBox5.Text = (from g in db.NHANVIENs
                              where g.MANV == strNhan
                              select g.TENNV).SingleOrDefault().ToString();
            textBox7.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.GIOITINH).SingleOrDefault().ToString();
            textBox9.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.SOCMND).SingleOrDefault().ToString();
            textBox4.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.DIENTHOAINV).SingleOrDefault().ToString();
            textBox1.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.DIACHI).SingleOrDefault().ToString();
            cHUCVUComboBox.Text = (from g in db.NHANVIENs
                                   from h in db.CHUCVUs
                                   where g.MANV == strNhan && g.MACHUCVU==h.MACHUCVU
                                   select h.TENCV).SingleOrDefault().ToString();
            maskedTextBox1.Text = (from g in db.NHANVIENs
                                   where g.MANV == strNhan
                                   select g.NGAYVAOLAM).SingleOrDefault().ToString();
            textBox2.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.TINHTRANG).SingleOrDefault().ToString();
            var f = (from g in db.NHANVIENs
                     where g.MANV == strNhan
                     select new
                     {
                         g.MANQL
                     });
            textBox11.Text = f.SingleOrDefault().ToString();
            
            textBox6.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.THUONGDOANHTHU).SingleOrDefault().ToString();
            textBox8.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.LUONGTRU).SingleOrDefault().ToString();
            textBox10.Text = (from g in db.NHANVIENs
                             where g.MANV == strNhan
                             select g.THUCLANH).SingleOrDefault().ToString();
        }

        private void cHUCVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHUCVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void cHUCVUComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void buttonX3_Click(object sender, EventArgs e)
        {
           
        }

        private void cHUCVUBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cHUCVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);
        
        }

        private void frm_ChiTietNhanVien_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet_ShopGiay.CHUCVU);
        
        }
    }
    
}
