namespace GUI
{
    partial class frm_NhatKiHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhatKiHeThong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDocTuTapTin = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuVaoTapTin = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtgvNhatKiHeThong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhatKiHeThong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.btnDocTuTapTin);
            this.panel1.Controls.Add(this.btnLuuVaoTapTin);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Appearance.Options.UseForeColor = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(483, 1);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(83, 29);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXuat.Appearance.Options.UseFont = true;
            this.btnXuat.Appearance.Options.UseForeColor = true;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(411, 1);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(72, 29);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất";
            // 
            // btnXem
            // 
            this.btnXem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.Appearance.Options.UseForeColor = true;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.Location = new System.Drawing.Point(1, 1);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(86, 29);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDocTuTapTin
            // 
            this.btnDocTuTapTin.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocTuTapTin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDocTuTapTin.Appearance.Options.UseFont = true;
            this.btnDocTuTapTin.Appearance.Options.UseForeColor = true;
            this.btnDocTuTapTin.Image = ((System.Drawing.Image)(resources.GetObject("btnDocTuTapTin.Image")));
            this.btnDocTuTapTin.Location = new System.Drawing.Point(292, 1);
            this.btnDocTuTapTin.Name = "btnDocTuTapTin";
            this.btnDocTuTapTin.Size = new System.Drawing.Size(119, 29);
            this.btnDocTuTapTin.TabIndex = 3;
            this.btnDocTuTapTin.Text = "Đọc từ tập tin";
            this.btnDocTuTapTin.Click += new System.EventHandler(this.btnDocTuTapTin_Click);
            // 
            // btnLuuVaoTapTin
            // 
            this.btnLuuVaoTapTin.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVaoTapTin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuuVaoTapTin.Appearance.Options.UseFont = true;
            this.btnLuuVaoTapTin.Appearance.Options.UseForeColor = true;
            this.btnLuuVaoTapTin.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuVaoTapTin.Image")));
            this.btnLuuVaoTapTin.Location = new System.Drawing.Point(173, 1);
            this.btnLuuVaoTapTin.Name = "btnLuuVaoTapTin";
            this.btnLuuVaoTapTin.Size = new System.Drawing.Size(119, 29);
            this.btnLuuVaoTapTin.TabIndex = 2;
            this.btnLuuVaoTapTin.Text = "Lưu vào tập tin";
            this.btnLuuVaoTapTin.Click += new System.EventHandler(this.btnLuuVaoTapTin_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(87, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvNhatKiHeThong
            // 
            this.dtgvNhatKiHeThong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvNhatKiHeThong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvNhatKiHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhatKiHeThong.Location = new System.Drawing.Point(3, 38);
            this.dtgvNhatKiHeThong.Name = "dtgvNhatKiHeThong";
            this.dtgvNhatKiHeThong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhatKiHeThong.Size = new System.Drawing.Size(715, 356);
            this.dtgvNhatKiHeThong.TabIndex = 1;
            // 
            // frm_NhatKiHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 395);
            this.Controls.Add(this.dtgvNhatKiHeThong);
            this.Controls.Add(this.panel1);
            this.Name = "frm_NhatKiHeThong";
            this.Text = "Nhật Kí Hệ Thống";
            this.Load += new System.EventHandler(this.frm_NhatKiHeThong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhatKiHeThong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnDocTuTapTin;
        private DevExpress.XtraEditors.SimpleButton btnLuuVaoTapTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dtgvNhatKiHeThong;
    }
}