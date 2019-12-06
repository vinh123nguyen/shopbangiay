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
    public partial class frm_hskh : Form
    {
        public frm_hskh()
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
        private void frm_hskh_Load(object sender, EventArgs e)
        {
            txt_makh.Text = db.SINHMA_Khachhang();
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text == "" || txttenkh.Text == "" || txtsdt.Text == "" || txtdc.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            KHACHHANG hd = new KHACHHANG();
            var kt = from s in db.KHACHHANGs where s.MAKH == txt_makh.Text select s;
            if (kt.Count() > 0)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }
            hd.MAKH = txt_makh.Text;
            hd.TENKH = txttenkh.Text;
            hd.SDTKHACHHANG = Convert.ToInt32( txtsdt.Text);
            hd.DIACHIKH = txtdc.Text;
            db.KHACHHANGs.InsertOnSubmit(hd);
            db.SubmitChanges();
            insert();
            MessageBox.Show("Thành công");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txt_makh.Text = txttenkh.Text = txtsdt.Text = txtdc.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
