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
    public partial class QLSuCo : Form
    {
        public QLSuCo()
        {
            InitializeComponent();
        }

        private void QLSuCo_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("SC1","Bung keo","15000");


        }

    }
}
