using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class frm_kn : Form
    {
        cauhinh ch = new cauhinh();
        public static SqlConnection conn;
        public frm_kn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            Formmain_MouseDown(sender, e);
        }

        private void logo_MouseMove(object sender, MouseEventArgs e)
        {
            Formmain_MouseMove(sender, e);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string bien = "Vui lòng điền ";
            try
            {
                if (cb_datasource.Text.Length == 0)
                    bien += "SeverName ";
                if (txt_pass.Text.Length == 0)
                    bien += "Password ";
                if (txt_user.Text.Length == 0)
                    bien += "UserName ";
                if (cb_server.Text.Length == 0)
                    bien += "DataBase ";
                if (cb_datasource.Text.Length != 0 && txt_pass.Text.Length != 0 && txt_user.Text.Length != 0 && cb_server.Text.Length != 0)
                {
                    bien = "Kết nối thành công";
                    conn = new SqlConnection(@"Data Source = " + cb_datasource.Text.ToString() + " ; Initial Catalog = " + cb_server.Text.ToString() + "; User ID = " + txt_user.Text.ToString() + "; Password = " + txt_pass.Text.ToString() + "");
                    conn.Open();
                }
                MessageBox.Show(bien);
            }
            catch(Exception b)
            {
                bien = "Kết nối thất bại"+b;
                MessageBox.Show(b.Message);
            }
        }

        private void cb_server_TextChanged(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cb_server.Items.Clear();

                List<string> _list = ch.GetDatabaseName(cb_datasource.Text.ToString(), txt_user.Text.ToString(), txt_pass.Text.ToString());
                if (_list == null)
                {
                    return;
                }
                foreach (string item in _list)
                {
                    cb_server.Items.Add(item);
                }
            }
        }
        private bool CheckedBeforSearchNameDB()
        {
            if (cb_datasource.Text.Length > 0 && txt_user.Text.Length > 0 && txt_pass.Text.Length > 0)
                return true;
            return false;
        }

        private void frm_kn_Load(object sender, EventArgs e)
        {
            DataTable dataTable = ch.GetServerName();
            cb_datasource.Items.Clear();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                foreach (System.Data.DataColumn col in dataTable.Columns)
                {
                    cb_datasource.Items.Add(row[col] + "\\SQLEXPRESS");
                }
            }
        }
        
    }
}
