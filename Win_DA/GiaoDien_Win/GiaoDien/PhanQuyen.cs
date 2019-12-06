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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void themNhomNDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.themNhomNDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ShopGiay);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.themNhomNDTableAdapter.Fill(this.dataSet_ShopGiay.ThemNhomND, mANHOMToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.QLNDNHOMND' table. You can move, or remove it, as needed.
            this.qLNDNHOMNDTableAdapter.Fill(this.dataSet_ShopGiay.QLNDNHOMND);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.QLNHOMND' table. You can move, or remove it, as needed.
            this.qLNHOMNDTableAdapter.Fill(this.dataSet_ShopGiay.QLNHOMND);
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.QUANLYND' table. You can move, or remove it, as needed.
            this.qUANLYNDTableAdapter.Fill(this.dataSet_ShopGiay.QUANLYND);

        }
        private void loaddl()
        {
            if (qLNHOMNDComboBox.SelectedValue != null)
            {
                try
                {
                    this.themNhomNDTableAdapter.Fill(this.dataSet_ShopGiay.ThemNhomND, qLNHOMNDComboBox.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void qLNHOMNDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddl();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                String snd = qUANLYNDDataGridView.CurrentRow.Cells[0].Value.ToString();
                String mnhom = qLNHOMNDComboBox.SelectedValue.ToString();
                qLNDNHOMNDTableAdapter.Insert(snd, mnhom, string.Empty);
                loaddl();
                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            String s=themNhomNDDataGridView.CurrentRow.Cells[0].Value.ToString();
            String mnhom = qLNHOMNDComboBox.SelectedValue.ToString();
          
                this.qLNDNHOMNDTableAdapter.Delete(s, mnhom, string.Empty);
                loaddl();
            
        }

        private void themNhomNDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
