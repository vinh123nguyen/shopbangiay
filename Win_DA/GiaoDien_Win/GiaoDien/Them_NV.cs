using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Them_NV : Form
    {
       
        public Them_NV(us_NhanVien us)
        {
            InitializeComponent();
            
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanv.Text == "" || txttennv.Text == "" || txtcmnd.Text == "" || txtsdt.Text == "" || txtdiachi.Text == ""
           || cHUCVUComboBox.Text == "" || nvl.Text == "")
                {
                    MessageBox.Show("không được để trống");
                    return;
                }
                var kt = (from s in db.NHANVIENs
                          where s.MANV == txtmanv.Text.ToString()
                          select new
                          {
                              s
                          });
                if (kt.Count() == 0)
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MANV = txtmanv.Text.ToString();
                    nv.TENNV = txttennv.Text.ToString();
                    if (rdo_nam.Checked == true)
                    {
                        nv.GIOITINH = "Nam";
                    }
                    else
                    {
                        if (rdonu.Checked == true)
                        {
                            nv.GIOITINH = "Nữ";
                        }
                    }
                    nv.SOCMND = Convert.ToInt32(txtcmnd.Text.ToString());
                    nv.DIENTHOAINV = Convert.ToInt32(txtsdt.Text.ToString());
                    nv.DIACHI = txtdiachi.Text.ToString();
                    nv.MACHUCVU = cHUCVUComboBox.SelectedValue.ToString();
                    nv.TINHTRANG = "Đang làm việc";
                    nv.NGAYVAOLAM = Convert.ToDateTime(nvl.Text.ToString());
                    nv.MANQL = "NV08";
                    nv.THUONGDOANHTHU = 0;
                    nv.LUONGTRU = 0;
                    nv.THUCLANH = 0;

                    db.NHANVIENs.InsertOnSubmit(nv);
                    db.SubmitChanges();
                    Them_NV_Load(sender,e);
                    MessageBox.Show("thành công");
                    insert();
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
        
        private void Them_NV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.dataSet_ShopGiay.CHUCVU);
            txtmanv.Text = db.SINHMA_NV();

        }

        private void cHUCVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHUCVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
