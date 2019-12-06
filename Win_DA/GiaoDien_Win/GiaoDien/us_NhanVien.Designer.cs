namespace GiaoDien
{
    partial class us_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_NhanVien));
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dataSet_ShopGiay = new GiaoDien.DataSet_ShopGiay();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager();
            this.nHANVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.BackColor = System.Drawing.Color.Green;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsua.Location = new System.Drawing.Point(897, 0);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 37);
            this.btnsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnsua.Symbol = "";
            this.btnsua.SymbolColor = System.Drawing.Color.SeaGreen;
            this.btnsua.TabIndex = 59;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.BackColor = System.Drawing.Color.Green;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnxoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnxoa.Location = new System.Drawing.Point(803, 0);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 37);
            this.btnxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnxoa.Symbol = "";
            this.btnxoa.SymbolColor = System.Drawing.Color.SeaGreen;
            this.btnxoa.TabIndex = 60;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThem.Location = new System.Drawing.Point(709, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 37);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnThem.Symbol = "";
            this.btnThem.SymbolColor = System.Drawing.Color.SeaGreen;
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(197, 3);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(287, 29);
            this.txttimkiem.TabIndex = 62;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(457, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 27);
            this.pictureBox6.TabIndex = 63;
            this.pictureBox6.TabStop = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.Color.RoyalBlue;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pictureBox6);
            this.panelEx1.Controls.Add(this.txttimkiem);
            this.panelEx1.Controls.Add(this.btnThem);
            this.panelEx1.Controls.Add(this.btnxoa);
            this.panelEx1.Controls.Add(this.btnsua);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(991, 37);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.DarkKhaki;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 94;
            // 
            // dataSet_ShopGiay
            // 
            this.dataSet_ShopGiay.DataSetName = "DataSet_ShopGiay";
            this.dataSet_ShopGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DMTKTableAdapter = null;
            this.tableAdapterManager.DONDATHANGKHTableAdapter = null;
            this.tableAdapterManager.GIAOHANGTableAdapter = null;
            this.tableAdapterManager.HOADONBANTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.LOAIGIAYTableAdapter = null;
            this.tableAdapterManager.NHACCTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
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
            // nHANVIENDataGridView
            // 
            this.nHANVIENDataGridView.AllowUserToAddRows = false;
            this.nHANVIENDataGridView.AutoGenerateColumns = false;
            this.nHANVIENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nHANVIENDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.nHANVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHANVIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.nHANVIENDataGridView.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENDataGridView.Location = new System.Drawing.Point(0, 37);
            this.nHANVIENDataGridView.Name = "nHANVIENDataGridView";
            this.nHANVIENDataGridView.Size = new System.Drawing.Size(991, 490);
            this.nHANVIENDataGridView.TabIndex = 109;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TENNV";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tên nhân viên";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GIOITINH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOCMND";
            this.dataGridViewTextBoxColumn3.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIENTHOAINV";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn5.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MACHUCVU";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã chức vụ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TINHTRANG";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NGAYVAOLAM";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngày vào làm";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MANQL";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã quản lý";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "THUONGDOANHTHU";
            this.dataGridViewTextBoxColumn10.HeaderText = "Thưởng doanh thu";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LUONGTRU";
            this.dataGridViewTextBoxColumn11.HeaderText = "Lương trừ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "THUCLANH";
            this.dataGridViewTextBoxColumn12.HeaderText = "Thực lãnh";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // us_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nHANVIENDataGridView);
            this.Controls.Add(this.panelEx1);
            this.Name = "us_NhanVien";
            this.Size = new System.Drawing.Size(991, 527);
            this.Load += new System.EventHandler(this.us_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DataSet_ShopGiay dataSet_ShopGiay;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DataSet_ShopGiayTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DataSet_ShopGiayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nHANVIENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

    }
}
