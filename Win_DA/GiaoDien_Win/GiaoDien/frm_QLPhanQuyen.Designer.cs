namespace GiaoDien
{
    partial class frm_QLPhanQuyen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.dataSet_ShopGiay = new GiaoDien.DataSet_ShopGiay();
            this.qLPHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPHANQUYENTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.QLPHANQUYENTableAdapter();
            this.tableAdapterManager = new GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager();
            this.qLPHANQUYENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.Sua = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtCoquyen = new DevExpress.XtraEditors.TextEdit();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.qLNHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHOMNDTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.QLNHOMNDTableAdapter();
            this.cboMaNhom = new System.Windows.Forms.ComboBox();
            this.dMMANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMMANHINHTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.DMMANHINHTableAdapter();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoquyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMANHINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboMaMH);
            this.panel2.Controls.Add(this.cboMaNhom);
            this.panel2.Controls.Add(this.txtCoquyen);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.panelEx2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 152);
            this.panel2.TabIndex = 104;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.Color.RoyalBlue;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btn_them);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(677, 37);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.DarkKhaki;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 73;
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.BackColor = System.Drawing.Color.Green;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_them.Location = new System.Drawing.Point(542, 0);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(135, 37);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btn_them.Symbol = "";
            this.btn_them.SymbolColor = System.Drawing.Color.SeaGreen;
            this.btn_them.TabIndex = 59;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataSet_ShopGiay
            // 
            this.dataSet_ShopGiay.DataSetName = "DataSet_ShopGiay";
            this.dataSet_ShopGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLPHANQUYENBindingSource
            // 
            this.qLPHANQUYENBindingSource.DataMember = "QLPHANQUYEN";
            this.qLPHANQUYENBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // qLPHANQUYENTableAdapter
            // 
            this.qLPHANQUYENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QLDNTableAdapter = null;
            
            this.tableAdapterManager.QLNDNHOMNDTableAdapter = null;
            this.tableAdapterManager.QLNHOMNDTableAdapter = null;
            this.tableAdapterManager.QLPHANQUYENTableAdapter = this.qLPHANQUYENTableAdapter;
            this.tableAdapterManager.QUANLYNDTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.SIZEGIAYTableAdapter = null;
            this.tableAdapterManager.THONGKE_CUOINAMTableAdapter = null;
            this.tableAdapterManager.THONGKE_DSTableAdapter = null;
            this.tableAdapterManager.THONGKE_SCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLPHANQUYENDataGridView
            // 
            this.qLPHANQUYENDataGridView.AllowUserToAddRows = false;
            this.qLPHANQUYENDataGridView.AutoGenerateColumns = false;
            this.qLPHANQUYENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qLPHANQUYENDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.qLPHANQUYENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qLPHANQUYENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Xoa,
            this.Sua});
            this.qLPHANQUYENDataGridView.DataSource = this.qLPHANQUYENBindingSource;
            this.qLPHANQUYENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qLPHANQUYENDataGridView.Location = new System.Drawing.Point(0, 152);
            this.qLPHANQUYENDataGridView.Name = "qLPHANQUYENDataGridView";
            this.qLPHANQUYENDataGridView.Size = new System.Drawing.Size(677, 299);
            this.qLPHANQUYENDataGridView.TabIndex = 105;
            this.qLPHANQUYENDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.qLPHANQUYENDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAMANHINH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã màn hình";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "COQUYEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Có quyền";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Image = global::GiaoDien.Properties.Resources.thungRac;
            this.Xoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Xoa.Name = "Xoa";
            // 
            // Sua
            // 
            this.Sua.HeaderText = "Sửa";
            this.Sua.Image = global::GiaoDien.Properties.Resources.pencil_tip_48px;
            this.Sua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Sua.Name = "Sua";
            // 
            // txtCoquyen
            // 
            this.txtCoquyen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qLPHANQUYENBindingSource, "COQUYEN", true));
            this.txtCoquyen.Location = new System.Drawing.Point(117, 111);
            this.txtCoquyen.Name = "txtCoquyen";
            this.txtCoquyen.Size = new System.Drawing.Size(423, 20);
            this.txtCoquyen.TabIndex = 109;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 109);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 106;
            this.labelX1.Text = "Có quyền";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 41);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(111, 23);
            this.labelX4.TabIndex = 105;
            this.labelX4.Text = "Mã nhóm";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 74);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 104;
            this.labelX7.Text = "Mã màn hình";
            // 
            // qLNHOMNDBindingSource
            // 
            this.qLNHOMNDBindingSource.DataMember = "QLNHOMND";
            this.qLNHOMNDBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // qLNHOMNDTableAdapter
            // 
            this.qLNHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // cboMaNhom
            // 
            this.cboMaNhom.DataSource = this.qLNHOMNDBindingSource;
            this.cboMaNhom.DisplayMember = "MANHOM";
            this.cboMaNhom.FormattingEnabled = true;
            this.cboMaNhom.Location = new System.Drawing.Point(117, 43);
            this.cboMaNhom.Name = "cboMaNhom";
            this.cboMaNhom.Size = new System.Drawing.Size(423, 21);
            this.cboMaNhom.TabIndex = 109;
            this.cboMaNhom.ValueMember = "MANHOM";
            // 
            // dMMANHINHBindingSource
            // 
            this.dMMANHINHBindingSource.DataMember = "DMMANHINH";
            this.dMMANHINHBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // dMMANHINHTableAdapter
            // 
            this.dMMANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // cboMaMH
            // 
            this.cboMaMH.DataSource = this.dMMANHINHBindingSource;
            this.cboMaMH.DisplayMember = "MAMANHINH";
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(117, 76);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(423, 21);
            this.cboMaMH.TabIndex = 109;
            this.cboMaMH.ValueMember = "MAMANHINH";
            // 
            // frm_QLPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 451);
            this.Controls.Add(this.qLPHANQUYENDataGridView);
            this.Controls.Add(this.panel2);
            this.Name = "frm_QLPhanQuyen";
            this.Text = "frm_QLPhanQuyen";
            this.Load += new System.EventHandler(this.frm_QLPhanQuyen_Load);
            this.panel2.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPHANQUYENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoquyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHOMNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMANHINHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DataSet_ShopGiay dataSet_ShopGiay;
        private System.Windows.Forms.BindingSource qLPHANQUYENBindingSource;
        private DataSet_ShopGiayTableAdapters.QLPHANQUYENTableAdapter qLPHANQUYENTableAdapter;
        private DataSet_ShopGiayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qLPHANQUYENDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
        private System.Windows.Forms.DataGridViewImageColumn Sua;
        private DevExpress.XtraEditors.TextEdit txtCoquyen;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.BindingSource qLNHOMNDBindingSource;
        private DataSet_ShopGiayTableAdapters.QLNHOMNDTableAdapter qLNHOMNDTableAdapter;
        private System.Windows.Forms.ComboBox cboMaNhom;
        private System.Windows.Forms.BindingSource dMMANHINHBindingSource;
        private DataSet_ShopGiayTableAdapters.DMMANHINHTableAdapter dMMANHINHTableAdapter;
        private System.Windows.Forms.ComboBox cboMaMH;

    }
}