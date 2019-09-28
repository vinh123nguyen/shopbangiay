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
    public partial class us_NhanVien : UserControl
    {
        public us_NhanVien()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Them_NV nv = new Them_NV();
            nv.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
