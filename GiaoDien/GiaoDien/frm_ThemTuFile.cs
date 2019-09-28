using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GiaoDien
{
    public partial class frm_ThemTuFile : Form
    {
        public frm_ThemTuFile()
        {
            InitializeComponent();
        }

        private void frm_ThemTuFile_Load(object sender, EventArgs e)
        {
            //ReadExcelContents(FN);
        }
        string FN;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_link.Text = open.FileName;
            }
            FN = txt_link.Text.ToString();
            
            MessageBox.Show(FN);
        }
        public DataTable ReadExcelContents(string fileName)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();

                connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + fileName); //Excel 97-2003, .xls
                string excelQuery = @"Select [Day],[Outlook],[temp],[Humidity],[Wind], [PlaySport] 
                   FROM [Sheet1$]";

                //string excelQuery = @"Select * FROM [Sheet1$]";        
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(excelQuery, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewX1.DataSource = dt.DefaultView;
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("File không tồn tại. " + ex.Message, "vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            ReadExcelContents(FN);  
        }
    
    }
}
