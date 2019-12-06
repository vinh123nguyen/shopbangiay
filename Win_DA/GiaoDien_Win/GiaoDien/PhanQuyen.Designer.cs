namespace GiaoDien
{
    partial class PhanQuyen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qUANLYNDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qUANLYNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ShopGiay = new GiaoDien.DataSet_ShopGiay();
            this.themNhomNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themNhomNDTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.ThemNhomNDTableAdapter();
            this.tableAdapterManager = new GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager();
            this.qLNDNHOMNDTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.QLNDNHOMNDTableAdapter();
            this.qLNHOMNDTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.QLNHOMNDTableAdapter();
            this.qUANLYNDTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.QUANLYNDTableAdapter();
            this.qLNHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.themNhomNDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.qLNHOMNDComboBox = new System.Windows.Forms.ComboBox();
            this.qLNDNHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themNhomNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNDBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themNhomNDDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.qUANLYNDDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // qUANLYNDDataGridView
            // 
            this.qUANLYNDDataGridView.AutoGenerateColumns = false;
            this.qUANLYNDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qUANLYNDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qUANLYNDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.qUANLYNDDataGridView.DataSource = this.qUANLYNDBindingSource;
            this.qUANLYNDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qUANLYNDDataGridView.Location = new System.Drawing.Point(3, 16);
            this.qUANLYNDDataGridView.Name = "qUANLYNDDataGridView";
            this.qUANLYNDDataGridView.Size = new System.Drawing.Size(254, 589);
            this.qUANLYNDDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MK";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HOATDONG";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Hoạt động";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // qUANLYNDBindingSource
            // 
            this.qUANLYNDBindingSource.DataMember = "QUANLYND";
            this.qUANLYNDBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // dataSet_ShopGiay
            // 
            this.dataSet_ShopGiay.DataSetName = "DataSet_ShopGiay";
            this.dataSet_ShopGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // themNhomNDBindingSource
            // 
            this.themNhomNDBindingSource.DataMember = "ThemNhomND";
            this.themNhomNDBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // themNhomNDTableAdapter
            // 
            this.themNhomNDTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUBAOHANHTableAdapter = null;
            this.tableAdapterManager.PHIEUDATHANGNCCTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.QL_NDNHOMND1TableAdapter = null;
            this.tableAdapterManager.QLDNTableAdapter = null;
            this.tableAdapterManager.QLNDNHOMNDTableAdapter = this.qLNDNHOMNDTableAdapter;
            this.tableAdapterManager.QLNHOMNDTableAdapter = this.qLNHOMNDTableAdapter;
            this.tableAdapterManager.QLPHANQUYENTableAdapter = null;
            this.tableAdapterManager.QUANLYNDTableAdapter = this.qUANLYNDTableAdapter;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.SIZEGIAYTableAdapter = null;
            this.tableAdapterManager.ThemNhomNDTableAdapter = this.themNhomNDTableAdapter;
            this.tableAdapterManager.THONGKE_CUOINAMTableAdapter = null;
            this.tableAdapterManager.THONGKE_DSTableAdapter = null;
            this.tableAdapterManager.THONGKE_SCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLNDNHOMNDTableAdapter
            // 
            this.qLNDNHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // qLNHOMNDTableAdapter
            // 
            this.qLNHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // qUANLYNDTableAdapter
            // 
            this.qUANLYNDTableAdapter.ClearBeforeFill = true;
            // 
            // qLNHOMNDBindingSource
            // 
            this.qLNHOMNDBindingSource.DataMember = "QLNHOMND";
            this.qLNHOMNDBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.buttonX2);
            this.groupBox4.Controls.Add(this.buttonX1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(260, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(92, 608);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX2.Location = new System.Drawing.Point(10, 223);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 36);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "   ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Location = new System.Drawing.Point(9, 143);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.DarkGreen;
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.themNhomNDDataGridView);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(352, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 608);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // themNhomNDDataGridView
            // 
            this.themNhomNDDataGridView.AutoGenerateColumns = false;
            this.themNhomNDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.themNhomNDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themNhomNDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.themNhomNDDataGridView.DataSource = this.themNhomNDBindingSource;
            this.themNhomNDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themNhomNDDataGridView.Location = new System.Drawing.Point(3, 84);
            this.themNhomNDDataGridView.Name = "themNhomNDDataGridView";
            this.themNhomNDDataGridView.Size = new System.Drawing.Size(296, 521);
            this.themNhomNDDataGridView.TabIndex = 1;
            this.themNhomNDDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.themNhomNDDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhóm người dùng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.qLNHOMNDComboBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 68);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // qLNHOMNDComboBox
            // 
            this.qLNHOMNDComboBox.DataSource = this.qLNHOMNDBindingSource;
            this.qLNHOMNDComboBox.DisplayMember = "TENNHOMND";
            this.qLNHOMNDComboBox.FormattingEnabled = true;
            this.qLNHOMNDComboBox.Location = new System.Drawing.Point(38, 27);
            this.qLNHOMNDComboBox.Name = "qLNHOMNDComboBox";
            this.qLNHOMNDComboBox.Size = new System.Drawing.Size(212, 21);
            this.qLNHOMNDComboBox.TabIndex = 0;
            this.qLNHOMNDComboBox.ValueMember = "MANHOM";
            this.qLNHOMNDComboBox.SelectedIndexChanged += new System.EventHandler(this.qLNHOMNDComboBox_SelectedIndexChanged);
            // 
            // qLNDNHOMNDBindingSource
            // 
            this.qLNDNHOMNDBindingSource.DataMember = "QLNDNHOMND";
            this.qLNDNHOMNDBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 608);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themNhomNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNDBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.themNhomNDDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet_ShopGiay dataSet_ShopGiay;
        private System.Windows.Forms.BindingSource themNhomNDBindingSource;
        private DataSet_ShopGiayTableAdapters.ThemNhomNDTableAdapter themNhomNDTableAdapter;
        private DataSet_ShopGiayTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet_ShopGiayTableAdapters.QUANLYNDTableAdapter qUANLYNDTableAdapter;
        private System.Windows.Forms.BindingSource qUANLYNDBindingSource;
        private System.Windows.Forms.DataGridView qUANLYNDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataSet_ShopGiayTableAdapters.QLNHOMNDTableAdapter qLNHOMNDTableAdapter;
        private System.Windows.Forms.BindingSource qLNHOMNDBindingSource;
        private DataSet_ShopGiayTableAdapters.QLNDNHOMNDTableAdapter qLNDNHOMNDTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView themNhomNDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox qLNHOMNDComboBox;
        private System.Windows.Forms.BindingSource qLNDNHOMNDBindingSource;
    }
}