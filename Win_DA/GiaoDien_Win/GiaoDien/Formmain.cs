using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using GiaoDien.CLASS;

namespace GiaoDien
{
    public partial class Formmain : Form
    {
        private string tendn;
        UC_Tongquat u = new UC_Tongquat();
        
        us_main u2 = new us_main();
        public Formmain()
        {
            InitializeComponent();
        }
        int p = 52;
        int d = 0;
        public string Tendn
        {
            get { return tendn; }
            set { tendn = value; }
        }
        kiemtradangnhap kt = new kiemtradangnhap();
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void Formmain_Load(object sender, EventArgs e)
        {

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            panel1.Width = p;
            lb_manv.Text = Tendn;
            var ktt = (from nv in db.NHANVIENs where nv.MANV == lb_manv.Text select nv.TENNV).FirstOrDefault();
            foreach (Control item in Hienthi.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    continue;
                }
                else
                {
                    item.Visible = kt.kiemtraquyentruycap(tendn, item.Tag.ToString());

                }
            }
            foreach (Control item in panel1.Controls)
            {
                if (item.GetType() == typeof(Label))
                {
                    continue;
                }
                else
                {
                    item.Visible = kt.kiemtraquyentruycap(tendn, item.Tag.ToString());

                }


            }
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                this.WindowState = FormWindowState.Maximized;

                if (nh == 0)
                {
                    u.Width = panelEx_hienthitongquat.Width;
                    u.Height = panelEx_hienthitongquat.Height;
                    panelEx_hienthitongquat.Controls.Add(u);
                }
                
                    
                d = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                if (nh == 0)
                {
                    u.Width = panelEx_hienthitongquat.Width;
                    u.Height = panelEx_hienthitongquat.Height;
                    panelEx_hienthitongquat.Controls.Add(u);
                }
                d = 0;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (panel1.Width == p)
            {
                panel1.Visible = false;
                panel1.Width = 250;
                bfb_ht.Width = 200;
                bfb_banghang.Width = 200;
                bfb_baocao.Width = 200;
                bfb_suco.Width = 200;
                bfb_sp.Width = 200;
                bfb_nhaphang.Width = 200;
                bfb_khachhang.Width = 200;
                bfb_nhomquyen.Width = 200;
                bunifuTransition1.Show(panel1);
                bunifuImageButton1.Hide();
                khoa(true);
                //panel1.AutoScroll = true;
                
            }
        }
        
        private void khoa(bool v)
        {
            bfb_banghang.Enabled = v;
            bfb_baocao.Enabled = v;         
            bfb_khachhang.Enabled = v;     
            bfb_nhomquyen.Enabled = v;
            bfb_suco.Enabled = v;
            bfb_nhaphang.Enabled = v;
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                panel1.Visible = false;
                panel1.Width = p;
                bunifuImageButton1.Show();
                bunifuTransition1.Show(panel1);
                khoa(false);
                //panel1.AutoScroll = false;
            }
        }
        
        int newLocationX, newLocationY;
        private void Formmain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void Formmain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }
        int nh = 0;
       

        private void bfb_tongquat_Click(object sender, EventArgs e)
        {
            //pictureBox4.Show();
            //pictureBox3.Show();
            //nh = 0;
            if (panel1.Width != p)
            {
                //bunifuImageButton2_Click(sender, e);
                //panelEx_hienthitongquat.Controls.Clear();
                //u.Width = 100;//panelEx_hienthitongquat.Width - p;
                //u.Height = panelEx_hienthitongquat.Height;
                //panelEx_hienthitongquat.Controls.Add(u);
                //pictureBox3_Click(sender,e);
                frm_tongquat tq = new frm_tongquat();
                tq.Show();
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_kho_Click(object sender, EventArgs e)
        {

        }

        private void bfb_baocao_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                //frm_ThongKe tk = new frm_ThongKe();
                //tk.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbTK.Visible = true;
                gbNhapHang.Visible = gbSuCo.Visible = gbSanPham.Visible = gbNguoidung.Visible = gbPhanQUyen.Visible = gbBanHang.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_banghang_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {

                //CTHD bh = new CTHD();
                //bh.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbBanHang.Visible = true;
                gbNhapHang.Visible = gbSuCo.Visible = gbSanPham.Visible = gbNguoidung.Visible = gbPhanQUyen.Visible = gbTK.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_khachhang_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                
                //frm_kh kh = new frm_kh();
                //kh.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbNguoidung.Visible = true;
                gbNhapHang.Visible = gbSuCo.Visible = gbSanPham.Visible = gbTK.Visible = gbPhanQUyen.Visible = gbTK.Visible = gbBanHang.Visible=false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_nhanvien_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                
                frm_NHANVIEN nv = new frm_NHANVIEN();
                nv.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void bfb_nhaphang_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                // nh = 1;
                // bunifuImageButton2_Click(sender, e);
                // if (d == 0)
                // {
                //     pictureBox3_Click(sender, e);
                // }
                //// panelEx_hienthitongquat.Controls.Clear();

                // pictureBox4.Hide();
                // pictureBox3.Hide();
                gbNhapHang.Visible = true;
                gbBanHang.Visible = gbSuCo.Visible = gbSanPham.Visible = gbNguoidung.Visible = gbPhanQUyen.Visible = gbTK.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_ncc_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                frm_ncc ncc = new frm_ncc();
                ncc.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void bfb_phanquyen_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                frm_QLPhanQuyen pq = new frm_QLPhanQuyen();
                pq.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void bfb_suco_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                
                //BBSuCo sc = new BBSuCo();
                //sc.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbSuCo.Visible = true;
                gbNhapHang.Visible = gbBanHang.Visible = gbSanPham.Visible = gbNguoidung.Visible = gbPhanQUyen.Visible = gbTK.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_nhomquyen_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
             
                //frm_QLPhanQuyen q = new frm_QLPhanQuyen();
                //q.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbPhanQUyen.Visible = true;
                gbNhapHang.Visible = gbSuCo.Visible = gbSanPham.Visible = gbNguoidung.Visible = gbBanHang.Visible = gbTK.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void bfb_dmsuco_Click(object sender, EventArgs e)
        {

        }

        private void bfb_khuyenmai_Click(object sender, EventArgs e)
        {

        }

        private void bfb_phanquyen_Click_1(object sender, EventArgs e)
        {

        }

        private void bfb_sp_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                //frm_sp sp = new frm_sp();
                //sp.Show();
                //this.WindowState = FormWindowState.Minimized;
                gbSanPham.Visible = true;
                gbNhapHang.Visible = gbSuCo.Visible = gbBanHang.Visible = gbNguoidung.Visible = gbPhanQUyen.Visible = gbTK.Visible = false;
            }
            bunifuImageButton2_Click(sender, e);
        }

   

        private void bfb_ddh_kh_Click(object sender, EventArgs e)
        {

        }

        private void bfb_dhch_Click(object sender, EventArgs e)
        {

        }

        private void banhang_Click(object sender, EventArgs e)
        {
            CTHD bh = new CTHD();
            bh.Ten = lb_manv.Text;
            bh.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void khuyenmai_Click(object sender, EventArgs e)
        {
            frm_KhuyenMai km = new frm_KhuyenMai();
            km.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void dondathangkh_Click(object sender, EventArgs e)
        {
            DDHKhachHang dhkh = new DDHKhachHang();
            dhkh.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void nhang_Click(object sender, EventArgs e)
        {
            frm_nhaphang nh = new frm_nhaphang();
            nh.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void ddh_ch_Click(object sender, EventArgs e)
        {
            frm_DatHangNCC dhkh = new frm_DatHangNCC();
            dhkh.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void khohang_Click(object sender, EventArgs e)
        {
            frm_kho k = new frm_kho();
            k.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void DMGIAY_Click(object sender, EventArgs e)
        {
            frm_dmsp dmsp = new frm_dmsp();
            dmsp.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void GIAY_Click(object sender, EventArgs e)
        {
            frm_sp sp = new frm_sp();
            sp.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void KHO_Click(object sender, EventArgs e)
        {
            frm_kho kho = new frm_kho();
            kho.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void DMSC_Click(object sender, EventArgs e)
        {
            QLSuCo SC = new QLSuCo();
            SC.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void BBSC_Click(object sender, EventArgs e)
        {
            BBSuCo sc = new BBSuCo();
            sc.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void NV_Click(object sender, EventArgs e)
        {
            frm_NHANVIEN nv = new frm_NHANVIEN();
            nv.Show();
        }

        private void KH_Click(object sender, EventArgs e)
        {
            frm_kh kh = new frm_kh();
            kh.Show();
        }

        private void NHOMQUYEN_Click(object sender, EventArgs e)
        {
            frm_QLPhanQuyen q = new frm_QLPhanQuyen();
            q.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void PHANQUYEN_Click(object sender, EventArgs e)
        {
            PhanQuyen pq = new PhanQuyen();
            pq.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void BC_Click(object sender, EventArgs e)
        {
            frm_ThongKe tk = new frm_ThongKe();
            tk.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void bfb_dx_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            this.Close();
        }

        private void bfb_ht_Click(object sender, EventArgs e)
        {
            if (panel1.Width != p)
            {
                gbNhapHang.Visible = gbBanHang.Visible = gbTK.Visible  = gbNguoidung.Visible = gbPhanQUyen.Visible = gbTK.Visible = gbSuCo.Visible =gbSanPham.Visible= true;
            }
            bunifuImageButton2_Click(sender, e);
        }

        private void panelEx_hienthitongquat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tenmay_Click(object sender, EventArgs e)
        {

        }

        
      
    }
}
