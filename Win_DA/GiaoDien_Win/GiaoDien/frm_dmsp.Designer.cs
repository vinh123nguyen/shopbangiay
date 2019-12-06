namespace GiaoDien
{
    partial class frm_dmsp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dmsp));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dANHMUCSPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dANHMUCSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ShopGiay = new GiaoDien.DataSet_ShopGiay();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_Them = new DevComponents.DotNetBar.ButtonX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_madm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_tendm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dANHMUCSPTableAdapter = new GiaoDien.DataSet_ShopGiayTableAdapters.DANHMUCSPTableAdapter();
            this.tableAdapterManager = new GiaoDien.DataSet_ShopGiayTableAdapters.TableAdapterManager();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 28);
            this.panel3.TabIndex = 99;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CTHD_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTHD_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::GiaoDien.Properties.Resources._70879743_479396955983380_5225989156345217024_n;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 28);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(556, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 28);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(32, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(132, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(82, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 28);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(735, 424);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 100;
            this.panelEx1.Text = "panelEx1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 424);
            this.panel2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dANHMUCSPDataGridView);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(479, 424);
            this.groupControl1.TabIndex = 0;
            // 
            // dANHMUCSPDataGridView
            // 
            this.dANHMUCSPDataGridView.AllowUserToAddRows = false;
            this.dANHMUCSPDataGridView.AutoGenerateColumns = false;
            this.dANHMUCSPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dANHMUCSPDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dANHMUCSPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dANHMUCSPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dANHMUCSPDataGridView.DataSource = this.dANHMUCSPBindingSource;
            this.dANHMUCSPDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dANHMUCSPDataGridView.Location = new System.Drawing.Point(2, 20);
            this.dANHMUCSPDataGridView.Name = "dANHMUCSPDataGridView";
            this.dANHMUCSPDataGridView.Size = new System.Drawing.Size(475, 402);
            this.dANHMUCSPDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MADMSP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã danh mục sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENDMSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên danh mục sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dANHMUCSPBindingSource
            // 
            this.dANHMUCSPBindingSource.DataMember = "DANHMUCSP";
            this.dANHMUCSPBindingSource.DataSource = this.dataSet_ShopGiay;
            // 
            // dataSet_ShopGiay
            // 
            this.dataSet_ShopGiay.DataSetName = "DataSet_ShopGiay";
            this.dataSet_ShopGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 424);
            this.panel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panel7);
            this.groupControl2.Controls.Add(this.panel6);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(256, 424);
            this.groupControl2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Sua);
            this.panel7.Controls.Add(this.btn_xoa);
            this.panel7.Controls.Add(this.btn_Them);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(2, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 140);
            this.panel7.TabIndex = 5;
            // 
            // btn_Sua
            // 
            this.btn_Sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sua.AutoSize = true;
            this.btn_Sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(0, 92);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(252, 46);
            this.btn_Sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sua.Symbol = "";
            this.btn_Sua.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Sua.SymbolSize = 30F;
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.Black;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(0, 46);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(252, 46);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.Symbol = "";
            this.btn_xoa.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_xoa.SymbolSize = 30F;
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Them.AutoSize = true;
            this.btn_Them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(0, 0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(252, 46);
            this.btn_Them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Them.Symbol = "";
            this.btn_Them.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.SymbolSize = 30F;
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_madm);
            this.panel6.Controls.Add(this.labelX2);
            this.panel6.Controls.Add(this.txt_tendm);
            this.panel6.Controls.Add(this.labelX1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(2, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 100);
            this.panel6.TabIndex = 4;
            // 
            // txt_madm
            // 
            // 
            // 
            // 
            this.txt_madm.Border.Class = "TextBoxBorder";
            this.txt_madm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_madm.Location = new System.Drawing.Point(118, 16);
            this.txt_madm.Name = "txt_madm";
            this.txt_madm.PreventEnterBeep = true;
            this.txt_madm.Size = new System.Drawing.Size(127, 21);
            this.txt_madm.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(10, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên danh mục";
            // 
            // txt_tendm
            // 
            // 
            // 
            // 
            this.txt_tendm.Border.Class = "TextBoxBorder";
            this.txt_tendm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tendm.Location = new System.Drawing.Point(118, 60);
            this.txt_tendm.Name = "txt_tendm";
            this.txt_tendm.PreventEnterBeep = true;
            this.txt_tendm.Size = new System.Drawing.Size(127, 21);
            this.txt_tendm.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(10, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(102, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã danh mục";
            // 
            // dANHMUCSPTableAdapter
            // 
            this.dANHMUCSPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DANHMUCSPTableAdapter = this.dANHMUCSPTableAdapter;
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
            // frm_dmsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 452);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dmsp";
            this.Text = "frm_dmsp";
            this.Load += new System.EventHandler(this.frm_dmsp_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ShopGiay)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ButtonX btn_Sua;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_Them;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_madm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tendm;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DataSet_ShopGiay dataSet_ShopGiay;
        private System.Windows.Forms.BindingSource dANHMUCSPBindingSource;
        private DataSet_ShopGiayTableAdapters.DANHMUCSPTableAdapter dANHMUCSPTableAdapter;
        private DataSet_ShopGiayTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dANHMUCSPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    }
}