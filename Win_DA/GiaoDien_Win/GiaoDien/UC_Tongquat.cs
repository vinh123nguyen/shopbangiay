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
    public partial class UC_Tongquat : UserControl
    {
        public UC_Tongquat()
        {
            InitializeComponent();
            dtgv_spbanchay.AllowUserToAddRows = false;
            dtgv_spbanchay.Enabled = true;
            dtgv_spbanchay.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dtgv_spbanchay.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dtgv_spbanchay.ReadOnly = true;
        }

        private void UC_Tongquat_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Product ID", typeof(string));
            dt.Columns.Add("Product Name", typeof(string));
            dt.Columns.Add("Product Quantity", typeof(int));



            dt.Rows.Add("13ZD", "AAAA", 11);
            dt.Rows.Add("13ZD", "AAAA", 4);

            dtgv_spbanchay.DataSource = dt;
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            //img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //object O = (System.Drawing.Image)Properties.Resources.thungRac;
            //Image image = (Image)O;

            //img.Image = image;
            //dtgv_spbanchay.Columns.Add(img);
            //img.HeaderText = "DELETE";
            //img.Name = "img";
            //dtgv_spbanchay.Columns[0].Visible = true;
        }

        private void dtgv_spbanchay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int rowIndex = e.RowIndex;
                dtgv_spbanchay.Rows.RemoveAt(rowIndex);

            }
        }



        
    }
}
