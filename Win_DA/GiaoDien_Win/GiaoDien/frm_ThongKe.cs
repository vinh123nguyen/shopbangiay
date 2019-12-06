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
    public partial class frm_ThongKe : Form
    {
        User_ds u = new User_ds();
        us_SuCo sc = new us_SuCo();
        us_CuoiNam cn = new us_CuoiNam();
        us_ThemDMTK them = new us_ThemDMTK();
        public frm_ThongKe()
        {
            InitializeComponent();
        }


        int lanbam=-1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 0;
            panel1.Controls.Clear();
            u.Width = panel1.Width;
            u.Height = panel1.Height;
            panel1.Controls.Add(u);
         
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    if (lanbam == 0)
                    {
                        u.Width = panel1.Width;
                        u.Height = panel1.Height;
                    }
                    else
                    {
                        if (lanbam == 1)
                        {
                            sc.Width = panel1.Width;
                            sc.Height = panel1.Height;
                            
                        }
                        else
                        {
                            if (lanbam == 2)
                            {
                                cn.Width = panel1.Width;
                                cn.Height = panel1.Height;
                                
                            }
                            else
                            {
                                if (lanbam == 3)
                                {
                                    them.Width = panel1.Width;
                                    them.Height = panel1.Height;
                                    
                                }
                            }
                        }
                    }

                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    if (lanbam == 0)
                    {
                        u.Width = panel1.Width;
                        u.Height = panel1.Height;
                        
                    }
                    else
                    {
                        if (lanbam == 1)
                        {
                            sc.Width = panel1.Width;
                            sc.Height = panel1.Height;
                            
                        }
                        else
                        {
                            if (lanbam == 2)
                            {
                                cn.Width = panel1.Width;
                                cn.Height = panel1.Height;
                                
                            }
                            else
                            {
                                if (lanbam == 3)
                                {
                                    them.Width = panel1.Width;
                                    them.Height = panel1.Height;
                                    
                                }
                            }
                        }
                    }
                    
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

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 1;
            panel1.Controls.Clear();
            sc.Width = panel1.Width;
            sc.Height = panel1.Height;
            panel1.Controls.Add(sc);
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 2;
            panel1.Controls.Clear();  
            cn.Width = panel1.Width;
            cn.Height = panel1.Height;         
            panel1.Controls.Add(cn);
           
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lanbam = 3;
            panel1.Controls.Clear();
            them.Width = panel1.Width;
            them.Height = panel1.Height;
            panel1.Controls.Add(them);
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
