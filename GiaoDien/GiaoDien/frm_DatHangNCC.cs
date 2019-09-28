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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frm_ThemDDH th = new frm_ThemDDH();
            th.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_ThemTuFile ttf = new frm_ThemTuFile();
            ttf.Show();
        }

  

        

     
    }
}
