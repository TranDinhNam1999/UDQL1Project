namespace GUI
{
    partial class frm_ThemQuyenHan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemQuyenHan));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLuuTQH = new DevExpress.XtraEditors.SimpleButton();
            this.btnDongTQH = new DevExpress.XtraEditors.SimpleButton();
            this.cbThenQuyenHan = new System.Windows.Forms.ComboBox();
            this.dtgvThemQuyenHan = new System.Windows.Forms.DataGridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemQuyenHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnLuuTQH);
            this.layoutControl1.Controls.Add(this.btnDongTQH);
            this.layoutControl1.Controls.Add(this.cbThenQuyenHan);
            this.layoutControl1.Controls.Add(this.dtgvThemQuyenHan);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 203);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLuuTQH
            // 
            this.btnLuuTQH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTQH.Image")));
            this.btnLuuTQH.Location = new System.Drawing.Point(12, 153);
            this.btnLuuTQH.Name = "btnLuuTQH";
            this.btnLuuTQH.Size = new System.Drawing.Size(410, 38);
            this.btnLuuTQH.StyleController = this.layoutControl1;
            this.btnLuuTQH.TabIndex = 8;
            this.btnLuuTQH.Text = "Lưu";
            this.btnLuuTQH.Click += new System.EventHandler(this.btnLuuTQH_Click);
            // 
            // btnDongTQH
            // 
            this.btnDongTQH.Image = ((System.Drawing.Image)(resources.GetObject("btnDongTQH.Image")));
            this.btnDongTQH.Location = new System.Drawing.Point(426, 153);
            this.btnDongTQH.Name = "btnDongTQH";
            this.btnDongTQH.Size = new System.Drawing.Size(412, 38);
            this.btnDongTQH.StyleController = this.layoutControl1;
            this.btnDongTQH.TabIndex = 7;
            this.btnDongTQH.Text = "Đóng";
            this.btnDongTQH.Click += new System.EventHandler(this.btnDongTQH_Click);
            // 
            // cbThenQuyenHan
            // 
            this.cbThenQuyenHan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThenQuyenHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThenQuyenHan.FormattingEnabled = true;
            this.cbThenQuyenHan.Location = new System.Drawing.Point(87, 12);
            this.cbThenQuyenHan.Name = "cbThenQuyenHan";
            this.cbThenQuyenHan.Size = new System.Drawing.Size(751, 27);
            this.cbThenQuyenHan.TabIndex = 5;
            this.cbThenQuyenHan.SelectedIndexChanged += new System.EventHandler(this.cbThenQuyenHan_SelectedIndexChanged);
            // 
            // dtgvThemQuyenHan
            // 
            this.dtgvThemQuyenHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThemQuyenHan.Location = new System.Drawing.Point(12, 45);
            this.dtgvThemQuyenHan.Name = "dtgvThemQuyenHan";
            this.dtgvThemQuyenHan.Size = new System.Drawing.Size(826, 104);
            this.dtgvThemQuyenHan.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 203);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtgvThemQuyenHan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(830, 108);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbThenQuyenHan;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(100, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(830, 33);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tên Tài Khoản:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDongTQH;
            this.layoutControlItem4.Location = new System.Drawing.Point(414, 141);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(416, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLuuTQH;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 141);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(414, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frm_ThemQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 203);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ThemQuyenHan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Quyền Hạn";
            this.Load += new System.EventHandler(this.frm_ThemQuyenHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThemQuyenHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnLuuTQH;
        private DevExpress.XtraEditors.SimpleButton btnDongTQH;
        private System.Windows.Forms.ComboBox cbThenQuyenHan;
        private System.Windows.Forms.DataGridView dtgvThemQuyenHan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}