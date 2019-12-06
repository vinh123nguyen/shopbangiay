namespace GiaoDien
{
    partial class themloaigiay
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
            this.txt_Maloai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Taomoi = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_tenloai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Maloai
            // 
            // 
            // 
            // 
            this.txt_Maloai.Border.Class = "TextBoxBorder";
            this.txt_Maloai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Maloai.Location = new System.Drawing.Point(156, 32);
            this.txt_Maloai.Multiline = true;
            this.txt_Maloai.Name = "txt_Maloai";
            this.txt_Maloai.PreventEnterBeep = true;
            this.txt_Maloai.Size = new System.Drawing.Size(294, 30);
            this.txt_Maloai.TabIndex = 0;
            // 
            // btn_Taomoi
            // 
            this.btn_Taomoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Taomoi.BackColor = System.Drawing.Color.Green;
            this.btn_Taomoi.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_Taomoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Taomoi.Location = new System.Drawing.Point(23, 122);
            this.btn_Taomoi.Name = "btn_Taomoi";
            this.btn_Taomoi.Size = new System.Drawing.Size(427, 30);
            this.btn_Taomoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Taomoi.Symbol = "";
            this.btn_Taomoi.SymbolColor = System.Drawing.Color.White;
            this.btn_Taomoi.TabIndex = 1;
            this.btn_Taomoi.Text = "Tạo mới";
            this.btn_Taomoi.TextColor = System.Drawing.Color.White;
            this.btn_Taomoi.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(127, 36);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Nhập mã loại giày mới";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 36);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Tên loại giày";
            // 
            // txt_tenloai
            // 
            // 
            // 
            // 
            this.txt_tenloai.Border.Class = "TextBoxBorder";
            this.txt_tenloai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tenloai.Location = new System.Drawing.Point(156, 68);
            this.txt_tenloai.Multiline = true;
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.PreventEnterBeep = true;
            this.txt_tenloai.Size = new System.Drawing.Size(294, 30);
            this.txt_tenloai.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 26);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.Knob_Red_icon;
            this.pictureBox1.Location = new System.Drawing.Point(430, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_huy.Location = new System.Drawing.Point(23, 158);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(427, 30);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.Symbol = "";
            this.btn_huy.SymbolColor = System.Drawing.Color.GhostWhite;
            this.btn_huy.TabIndex = 6;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextColor = System.Drawing.Color.White;
            // 
            // themloaigiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 210);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_tenloai);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_Taomoi);
            this.Controls.Add(this.txt_Maloai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "themloaigiay";
            this.Text = "themloaigiay";
            this.Load += new System.EventHandler(this.themloaigiay_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.themloaigiay_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.themloaigiay_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_Maloai;
        private DevComponents.DotNetBar.ButtonX btn_Taomoi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tenloai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btn_huy;
    }
}