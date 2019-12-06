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
    public partial class Form1 : Form
    {
        private string tendn;
        public Form1()
        {
            InitializeComponent();
        }
        public string Tendn
        {
            get { return tendn; }
            set { tendn = value; }
        }
        DataClasses2DataContext db = new DataClasses2DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            //int query = (from s in db.QLNDNHOMNDs
            //             join c in db.QLPHANQUYENs on s.MANHOM equals c.MANHOM
            //             where s.TENDN == "NV01" && c.MAMANHINH=="MH1"
            //             select new
            //             {
            //                 c.MAMANHINH
            //             }).Count();
            //MessageBox.Show(query.ToString());

            //foreach ( item in p.Controls)
            //{
            //    if (item.Tag.ToString() == "1")
            //    {
            //        item.Visible = false;
            //    }
            //}
        }

        private void tileBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
