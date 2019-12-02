using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLL_Users b_user = new BLL_Users();
        BLL_NhatKiHeThong b_nkht = new BLL_NhatKiHeThong();
        public string Users_Name = "";
        public void Get_name_user(string name)
        {
            Users_Name = name;
        }
        private void txtMatKhauDMK_Validating(object sender, CancelEventArgs e)
        {
            string checkpassword = @"^[a-zA-Z0-9\x20]+$";
            bool isPasswordValid = Regex.IsMatch(txtMatKhauDMK.Text, checkpassword);
            if (!isPasswordValid || txtMatKhauDMK.Text.Length < 3)
            {
                if (txtMatKhauDMK.Text.Length < 3)
                {
                    errorProviderApp.SetError(txtMatKhauDMK, "Mật khẩu không hợp lệ, độ dài phải lớn hơn 3");
                    txtMatKhauDMK.Focus();
                }
                else
                {
                    txtMatKhauDMK.Focus();
                    errorProviderApp.SetError(txtMatKhauDMK, "Mật khẩu không hợp lệ, không được chứa kí tự đặc biệt");
                }
            }
            else
            {
                errorProviderApp.SetError(txtMatKhauDMK, "");
            }
        }

        private void txtReMatKhauDMK_Validating(object sender, CancelEventArgs e)
        {
            if(txtReMatKhauDMK.Text != txtMatKhauDMK.Text)
            {
                errorProviderApp.SetError(txtReMatKhauDMK, "Mật khẩu không trùng khớp");
                txtMatKhauDMK.Focus();
            }
            else
            {
                errorProviderApp.SetError(txtReMatKhauDMK, "");
            }
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = Users_Name;
        }

        private void btnDongDMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkDMK_Click(object sender, EventArgs e)
        {
            try
            {
                b_user.Call_Update_password(Users_Name, txtTenTaiKhoan.Text);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                b_nkht.Call_Insert_NhatKiHeThong(Users_Name, "Bảo Mật", "Đổi Mật Khẩu");
            }
            catch
            {
                MessageBox.Show("Lỗi , không đổi mật ngay lúc này được");
            }
        }
    }
}
