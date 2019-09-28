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
    public partial class us_ChucVu : UserControl
    {
        public us_ChucVu()
        {
            InitializeComponent();
        }

        private void us_ChucVu_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("CV1", "Nhan Vien", "8115000");
        }
    }
}
