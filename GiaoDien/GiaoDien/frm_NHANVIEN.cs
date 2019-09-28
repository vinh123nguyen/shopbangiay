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
    public partial class frm_NHANVIEN : Form
    {
        us_ChucVu cv = new us_ChucVu();
        us_NhanVien nv = new us_NhanVien();
        us_TaiKhoanNV tknv = new us_TaiKhoanNV();
        us_NhomND nhomnd = new us_NhomND();
        public frm_NHANVIEN()
        {
            InitializeComponent();
        }
        int lanbam=-1;
        int d = 0;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 0;
            panel1.Controls.Clear();
            nv.Width = panel1.Width;
            nv.Height = panel1.Height;
            panel1.Controls.Add(nv);
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 1;
            panel1.Controls.Clear();
            tknv.Width = panel1.Width;
            tknv.Height = panel1.Height;
            panel1.Controls.Add(tknv);
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 2;
            panel1.Controls.Clear();
            cv.Width = panel1.Width;
            cv.Height = panel1.Height;
            panel1.Controls.Add(cv);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                if (lanbam == 0 )
                {
                    
                    nv.Width = panel1.Width;
                    nv.Height = panel1.Height;    
                   
                }
                else
                {
                    if (lanbam == 1 )
                    {
                        
                        tknv.Width = panel1.Width;
                        tknv.Height = panel1.Height;
                    }
                    else
                    {
                        if (lanbam == 2 )
                        {
                            
                            cv.Width = panel1.Width;
                            cv.Height = panel1.Height;
                        }
                        else
                            if (lanbam == 3 )
                            {
                                
                                nhomnd.Width = panel1.Width;
                                nhomnd.Height = panel1.Height;
                            }
                       
                    }
                }

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                if (lanbam == 0 )
                {
                    nv.Width = panel1.Width;
                    nv.Height = panel1.Height;
                }
                else
                {
                    if (lanbam == 1 )
                    {
                        tknv.Width = panel1.Width;
                        tknv.Height = panel1.Height;
                    }
                    else
                    {
                        if (lanbam == 2 )
                        {
                            cv.Width = panel1.Width;
                            cv.Height = panel1.Height;
                        }
                        else
                            if (lanbam == 3 )
                            {
                                nhomnd.Width = panel1.Width;
                                nhomnd.Height = panel1.Height;
                            }
                       
                    }
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 3;
            panel1.Controls.Clear();
            nhomnd.Width = panel1.Width;
            nhomnd.Height = panel1.Height;
            panel1.Controls.Add(nhomnd);
            
        }

        
    }
}
