namespace GUI
{
    partial class Frm_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PhanQuyen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgridPhanQuyen = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrNguoiDung = new System.Windows.Forms.DataGridView();
            this.btnDongVaitro = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaVaiTro = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaVaiTro = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNguoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPhanQuyen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Controls.Add(this.groupBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnThemPhanQuyen);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnDongVaitro);
            this.panel1.Controls.Add(this.btnXoaVaiTro);
            this.panel1.Controls.Add(this.btnSuaVaiTro);
            this.panel1.Controls.Add(this.btnThemNguoiDung);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnThemPhanQuyen
            // 
            this.btnThemPhanQuyen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemPhanQuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhanQuyen.Image")));
            this.btnThemPhanQuyen.Location = new System.Drawing.Point(113, -3);
            this.btnThemPhanQuyen.Name = "btnThemPhanQuyen";
            this.btnThemPhanQuyen.Size = new System.Drawing.Size(111, 35);
            this.btnThemPhanQuyen.TabIndex = 2;
            this.btnThemPhanQuyen.Text = "Thêm Quyền Hạn";
            this.btnThemPhanQuyen.Click += new System.EventHandler(this.btnThemPhanQuyen_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.Location = new System.Drawing.Point(426, -4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(350, 36);
            this.simpleButton1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtgridPhanQuyen);
            this.groupBox3.Location = new System.Drawing.Point(4, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 172);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền truy cập của người dùng";
            // 
            // dtgridPhanQuyen
            // 
            this.dtgridPhanQuyen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgridPhanQuyen.Location = new System.Drawing.Point(3, 16);
            this.dtgridPhanQuyen.Name = "dtgridPhanQuyen";
            this.dtgridPhanQuyen.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgridPhanQuyen.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridPhanQuyen.Size = new System.Drawing.Size(766, 153);
            this.dtgridPhanQuyen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgrNguoiDung);
            this.groupBox2.Location = new System.Drawing.Point(1, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 214);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Người Dùng";
            // 
            // dtgrNguoiDung
            // 
            this.dtgrNguoiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrNguoiDung.Location = new System.Drawing.Point(3, 16);
            this.dtgrNguoiDung.Name = "dtgrNguoiDung";
            this.dtgrNguoiDung.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgrNguoiDung.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrNguoiDung.Size = new System.Drawing.Size(769, 195);
            this.dtgrNguoiDung.TabIndex = 0;
            this.dtgrNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrNguoiDung_CellContentClick);
            // 
            // btnDongVaitro
            // 
            this.btnDongVaitro.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDongVaitro.Image = ((System.Drawing.Image)(resources.GetObject("btnDongVaitro.Image")));
            this.btnDongVaitro.Location = new System.Drawing.Point(359, -5);
            this.btnDongVaitro.Name = "btnDongVaitro";
            this.btnDongVaitro.Size = new System.Drawing.Size(66, 37);
            this.btnDongVaitro.TabIndex = 4;
            this.btnDongVaitro.Text = "Đóng";
            this.btnDongVaitro.Click += new System.EventHandler(this.btnDongVaitro_Click);
            // 
            // btnXoaVaiTro
            // 
            this.btnXoaVaiTro.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoaVaiTro.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaVaiTro.Image")));
            this.btnXoaVaiTro.Location = new System.Drawing.Point(292, -4);
            this.btnXoaVaiTro.Name = "btnXoaVaiTro";
            this.btnXoaVaiTro.Size = new System.Drawing.Size(66, 36);
            this.btnXoaVaiTro.TabIndex = 3;
            this.btnXoaVaiTro.Text = "Xoá";
            this.btnXoaVaiTro.Click += new System.EventHandler(this.btnXoaVaiTro_Click);
            // 
            // btnSuaVaiTro
            // 
            this.btnSuaVaiTro.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSuaVaiTro.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaVaiTro.Image")));
            this.btnSuaVaiTro.Location = new System.Drawing.Point(225, -5);
            this.btnSuaVaiTro.Name = "btnSuaVaiTro";
            this.btnSuaVaiTro.Size = new System.Drawing.Size(66, 37);
            this.btnSuaVaiTro.TabIndex = 2;
            this.btnSuaVaiTro.Text = "Sửa";
            this.btnSuaVaiTro.Click += new System.EventHandler(this.btnSuaVaiTro_Click);
            // 
            // btnThemNguoiDung
            // 
            this.btnThemNguoiDung.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoiDung.Image")));
            this.btnThemNguoiDung.Location = new System.Drawing.Point(1, -3);
            this.btnThemNguoiDung.Name = "btnThemNguoiDung";
            this.btnThemNguoiDung.Size = new System.Drawing.Size(111, 35);
            this.btnThemNguoiDung.TabIndex = 1;
            this.btnThemNguoiDung.Text = "Thêm người dùng";
            this.btnThemNguoiDung.Click += new System.EventHandler(this.btnThemNguoiDung_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(108, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 20);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.panel1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 430);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "Frm_PhanQuyen";
            this.ShowIcon = false;
            this.Text = "Phân Quyền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPhanQuyen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnDongVaitro;
        private DevExpress.XtraEditors.SimpleButton btnXoaVaiTro;
        private DevExpress.XtraEditors.SimpleButton btnSuaVaiTro;
        private DevExpress.XtraEditors.SimpleButton btnThemNguoiDung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgridPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrNguoiDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnThemPhanQuyen;
    }
}