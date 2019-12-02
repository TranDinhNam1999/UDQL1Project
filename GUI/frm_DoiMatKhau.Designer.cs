namespace GUI
{
    partial class frm_DoiMatKhau
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDongDMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnOkDMK = new DevExpress.XtraEditors.SimpleButton();
            this.txtReMatKhauDMK = new System.Windows.Forms.TextBox();
            this.txtMatKhauDMK = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = global::GUI.Properties.Resources.beautiful_color_gradients_backgrounds_001_warm_flame;
            this.panelControl1.Controls.Add(this.btnDongDMK);
            this.panelControl1.Controls.Add(this.btnOkDMK);
            this.panelControl1.Controls.Add(this.txtReMatKhauDMK);
            this.panelControl1.Controls.Add(this.txtMatKhauDMK);
            this.panelControl1.Controls.Add(this.txtTenTaiKhoan);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(419, 239);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDongDMK
            // 
            this.btnDongDMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongDMK.Appearance.Options.UseFont = true;
            this.btnDongDMK.Location = new System.Drawing.Point(241, 197);
            this.btnDongDMK.Name = "btnDongDMK";
            this.btnDongDMK.Size = new System.Drawing.Size(75, 30);
            this.btnDongDMK.TabIndex = 8;
            this.btnDongDMK.Text = "Đóng";
            this.btnDongDMK.Click += new System.EventHandler(this.btnDongDMK_Click);
            // 
            // btnOkDMK
            // 
            this.btnOkDMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkDMK.Appearance.Options.UseFont = true;
            this.btnOkDMK.Location = new System.Drawing.Point(147, 197);
            this.btnOkDMK.Name = "btnOkDMK";
            this.btnOkDMK.Size = new System.Drawing.Size(75, 30);
            this.btnOkDMK.TabIndex = 7;
            this.btnOkDMK.Text = "OK";
            this.btnOkDMK.Click += new System.EventHandler(this.btnOkDMK_Click);
            // 
            // txtReMatKhauDMK
            // 
            this.txtReMatKhauDMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReMatKhauDMK.Location = new System.Drawing.Point(146, 162);
            this.txtReMatKhauDMK.Name = "txtReMatKhauDMK";
            this.txtReMatKhauDMK.PasswordChar = '*';
            this.txtReMatKhauDMK.Size = new System.Drawing.Size(228, 26);
            this.txtReMatKhauDMK.TabIndex = 6;
            this.txtReMatKhauDMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtReMatKhauDMK_Validating);
            // 
            // txtMatKhauDMK
            // 
            this.txtMatKhauDMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauDMK.Location = new System.Drawing.Point(146, 118);
            this.txtMatKhauDMK.Name = "txtMatKhauDMK";
            this.txtMatKhauDMK.PasswordChar = '*';
            this.txtMatKhauDMK.Size = new System.Drawing.Size(228, 26);
            this.txtMatKhauDMK.TabIndex = 5;
            this.txtMatKhauDMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhauDMK_Validating);
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(146, 80);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(228, 26);
            this.txtTenTaiKhoan.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(30, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Mật khẩu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(30, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhập lại mật khẩu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(30, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tài khoản:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(147, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đổi Mật Khẩu";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 239);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DoiMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDongDMK;
        private DevExpress.XtraEditors.SimpleButton btnOkDMK;
        private System.Windows.Forms.TextBox txtReMatKhauDMK;
        private System.Windows.Forms.TextBox txtMatKhauDMK;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}