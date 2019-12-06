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
    public partial class frm_DatHangNCC : Form
    {
        public frm_DatHangNCC()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_ThemDDH th = new frm_ThemDDH(this);
            th.UpdateEventHandler += F2_UpdateEventHandler;
            //th.ShowDialog();
            th.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_ThemTuFile ttf = new frm_ThemTuFile();
            ttf.Show();
        }

        private void frm_DatHangNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.DDHNCC' table. You can move, or remove it, as needed.
            this.dDHNCCTableAdapter.Fill_DH(this.dataSet_ShopGiay.DDHNCC);
        }
        private void F2_UpdateEventHandler(object sender,frm_ThemDDH .UpdateEventArgs args)
        {
            this.dDHNCCTableAdapter.Fill_DH(this.dataSet_ShopGiay.DDHNCC);
        }
        private void dDHNCCDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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
