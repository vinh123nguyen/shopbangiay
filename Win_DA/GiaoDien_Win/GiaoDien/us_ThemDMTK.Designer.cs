namespace GiaoDien
{
    partial class us_ThemDMTK
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdanhmuc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtloaitk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dataSet_ShopGiay = new GiaoDien.DataSet_ShopGiay();
            this.dMTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMTKTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.DMTKTableAdapter();
            this.tableAdapterManager = new GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager();
            this.dMTKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.sua = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdanhmuc);
            this.panel1.Controls.Add(this.labelX9);
            this.panel1.Controls.Add(this.txtloaitk);
            this.panel1.Controls.Add(this.panelEx1);
            this.panel1.Controls.Add(this.labelX12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 111);
            this.panel1.TabIndex = 26;
            // 
            // txtdanhmuc
            // 
            // 
            // 
            // 
            this.txtdanhmuc.Border.Class = "TextBoxBorder";
            this.txtdanhmuc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdanhmuc.Location = new System.Drawing.Point(235, 39);
            this.txtdanhmuc.Multiline = true;
            this.txtdanhmuc.Name = "txtdanhmuc";
            this.txtdanhmuc.PreventEnterBeep = true;
            this.txtdanhmuc.Size = new System.Drawing.Size(358, 29);
            this.txtdanhmuc.TabIndex = 84;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(22, 39);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(170, 29);
            this.labelX9.TabIndex = 80;
            this.labelX9.Text = "Mã danh mục thống kê";
            // 
            // txtloaitk
            // 
            // 
            // 
            // 
            this.txtloaitk.Border.Class = "TextBoxBorder";
            this.txtloaitk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtloaitk.Location = new System.Drawing.Point(235, 77);
            this.txtloaitk.Multiline = true;
            this.txtloaitk.Name = "txtloaitk";
            this.txtloaitk.PreventEnterBeep = true;
            this.txtloaitk.Size = new System.Drawing.Size(358, 23);
            this.txtloaitk.TabIndex = 77;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.Color.RoyalBlue;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnthem);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(881, 35);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.DarkKhaki;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 73;
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.BackColor = System.Drawing.Color.Green;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnthem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnthem.Location = new System.Drawing.Point(746, 0);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(135, 35);
            this.btnthem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnthem.Symbol = "";
            this.btnthem.SymbolColor = System.Drawing.Color.SeaGreen;
            this.btnthem.TabIndex = 59;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(22, 77);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 21;
            this.labelX12.Text = "Loại thống kê";
            // 
            // dataSet_ShopGiay
            // 
            this.dataSet_ShopGiay.DataSetName = "DataSet_ShopGiay";
            this.dataSet_ShopGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMTKBindingSource
            // 
            this.dMTKBindingSource.DataMember = "DMTK";
            this.dMTKBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // dMTKTableAdapter
            // 
            this.dMTKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BIENBANSUCOTableAdapter = null;
            this.tableAdapterManager.CHITIETDDHKHACHHANGTableAdapter = null;
            this.tableAdapterManager.CHITIETHOADONBANTableAdapter = null;
            this.tableAdapterManager.CHITIETPHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.CHITIETTHONGKETableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CT_KHUYENMAITableAdapter = null;
            this.tableAdapterManager.CTBBSCTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATHANGNCCTableAdapter = null;
            this.tableAdapterManager.CTTKDSTableAdapter = null;
            this.tableAdapterManager.CTTKSCTableAdapter = null;
            this.tableAdapterManager.DANHMUCSP1TableAdapter = null;
            this.tableAdapterManager.DANHMUCSPTableAdapter = null;
            this.tableAdapterManager.DMMANHINHTableAdapter = null;
            this.tableAdapterManager.DMSUCOTableAdapter = null;
            this.tableAdapterManager.DMTKTableAdapter = this.dMTKTableAdapter;
            this.tableAdapterManager.DONDATHANGKHTableAdapter = null;
            this.tableAdapterManager.GIAOHANGTableAdapter = null;
            this.tableAdapterManager.HOADONBANTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.LOAIGIAYTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.PHIEUDATHANGNCCTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.QLDNTableAdapter = null;
           
            this.tableAdapterManager.QLNDNHOMNDTableAdapter = null;
            this.tableAdapterManager.QLNHOMNDTableAdapter = null;
            this.tableAdapterManager.QLPHANQUYENTableAdapter = null;
            this.tableAdapterManager.QUANLYNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.SIZEGIAYTableAdapter = null;
            this.tableAdapterManager.THONGKE_CUOINAMTableAdapter = null;
            this.tableAdapterManager.THONGKE_DSTableAdapter = null;
            this.tableAdapterManager.THONGKE_SCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dMTKDataGridView
            // 
            this.dMTKDataGridView.AutoGenerateColumns = false;
            this.dMTKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dMTKDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dMTKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dMTKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.xoa,
            this.sua});
            this.dMTKDataGridView.DataSource = this.dMTKBindingSource;
            this.dMTKDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dMTKDataGridView.Location = new System.Drawing.Point(0, 111);
            this.dMTKDataGridView.Name = "dMTKDataGridView";
            this.dMTKDataGridView.Size = new System.Drawing.Size(881, 356);
            this.dMTKDataGridView.TabIndex = 26;
            this.dMTKDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dMTKDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADMTK";
            this.dataGridViewTextBoxColumn1.HeaderText = "Danh mục thống kê";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOAITHONGKE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại thống kê";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.Image = global::GiaoDien.Properties.Resources.thungRac;
            this.xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.xoa.Name = "xoa";
            // 
            // sua
            // 
            this.sua.HeaderText = "Sửa";
            this.sua.Image = global::GiaoDien.Properties.Resources.pencil_tip_48px;
            this.sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.sua.Name = "sua";
            // 
            // us_ThemDMTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dMTKDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "us_ThemDMTK";
            this.Size = new System.Drawing.Size(881, 467);
            this.Load += new System.EventHandler(this.us_ThemDMTK_Load);
            this.panel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdanhmuc;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtloaitk;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DataSet_ShopGiay dataSet_ShopGiay;
        private System.Windows.Forms.BindingSource dMTKBindingSource;
        private DataSet_ShopGiayTableAdapters.DMTKTableAdapter dMTKTableAdapter;
        private DataSet_ShopGiayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dMTKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn xoa;
        private System.Windows.Forms.DataGridViewImageColumn sua;
    }
}
