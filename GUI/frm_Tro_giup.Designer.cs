namespace GUI
{
    partial class frm_Tro_giup
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
            this.menuControls1 = new GUI.MenuControls();
            this.SuspendLayout();
            // 
            // menuControls1
            // 
            this.menuControls1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuControls1.Location = new System.Drawing.Point(0, 0);
            this.menuControls1.Name = "menuControls1";
            this.menuControls1.Size = new System.Drawing.Size(835, 146);
            this.menuControls1.TabIndex = 0;
            this.menuControls1.Load += new System.EventHandler(this.menuControls1_Load_2);
            // 
            // frm_Tro_giup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.menuControls1);
            this.Name = "frm_Tro_giup";
            this.Text = "Trợ Giúp";
            this.Load += new System.EventHandler(this.frm_Tro_giup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuControls menuControls1;
    }
}