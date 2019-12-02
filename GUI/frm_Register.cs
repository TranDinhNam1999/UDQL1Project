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
using DTO;

namespace GUI
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {

        }
        public bool check_Is_Upper(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool check_Is_White_Space(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsWhiteSpace(s[i]))
                {
                    return true;
                }
            }
            return false;
        }
        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            string checkusename = @"^[a-zA-Z0-9-_.\x20]+$";
            bool isUsernameValid = Regex.IsMatch(txtUsername.Text, checkusename);
            if (!isUsernameValid)
            {
                errorProviderApp.SetError(txtUsername, "Tên đăng nhập không hợp lệ, không được chứa kí tự đặc biệt");
                txtUsername.Focus();
            }
            else if (check_Is_Upper(txtUsername.Text))
            {
                errorProviderApp.SetError(txtUsername, "Tên đăng nhập không hợp lệ, không được chứa kí tự in hoa");
                txtUsername.Focus();
            }
            else if (check_Is_White_Space(txtUsername.Text))
            {
                errorProviderApp.SetError(txtUsername, "Tên đăng nhập không hợp lệ, không được chứa khoảng trắng");
                txtUsername.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtUsername, "");
            }
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            string checkpassword = @"^[a-zA-Z0-9\x20]+$";
            bool isPasswordValid = Regex.IsMatch(txtpassword.Text, checkpassword);
            if (!isPasswordValid || txtpassword.Text.Length < 3)
            {
                if (txtpassword.Text.Length < 3)
                {
                    errorProviderApp.SetError(txtpassword, "Mật khẩu không hợp lệ, độ dài phải lớn hơn 3");
                    txtpassword.Focus();
                }
                else
                {
                    txtpassword.Focus();
                    errorProviderApp.SetError(txtpassword, "Mật khẩu không hợp lệ, không được chứa kí tự đặc biệt");
                }
            }
            else
            {
                errorProviderApp.SetError(txtpassword, "");
            }
        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (txtname.Text != "")
            {
                string tempname = txtname.Text;
                string checkname = @"^[a-zA-Z]+$";
                bool isNameValid = Regex.IsMatch(tempname[0].ToString(), checkname);
                if (!isNameValid)
                {
                    txtname.Focus();
                    errorProviderApp.SetError(txtname, "Tên không hợp lệ, kí tự đầu tiền không được là kí tự đặc biệt");
                }
                else
                {
                    errorProviderApp.SetError(txtname, "");
                }
            }
        }

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            bool isEmailValid = Regex.IsMatch(txtemail.Text, emailPattern);
            if (!isEmailValid)
            {
                errorProviderApp.SetError(txtemail, "Email không đúng");
                txtemail.Focus();
            }
            else
            {
                errorProviderApp.SetError(txtemail, "");
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DTO_Users dto_user = new DTO_Users();
            BLL_Users bll_user = new BLL_Users();
            BLL_Per b_per = new BLL_Per();
            string temp_urname = bll_user.Call_Get_Username_User(txtUsername.Text);
            if (txtname.Text == "" || txtpassword.Text == "" || txtemail.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Không được để trống bất cứ ô nào", "Thông báo", MessageBoxButtons.OK);
            }
            else if (temp_urname == txtUsername.Text)
            {
                MessageBox.Show("Tên Đăng nhập đã tồn tại, vui lòng nhập vào tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK);
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    dto_user.F_Username = txtUsername.Text;
                    dto_user.F_Password = txtpassword.Text;
                    dto_user.F_Name = txtname.Text;
                    dto_user.F_DOB = DateTime.Parse(dtdbo.Text);
                    dto_user.F_Email = txtemail.Text;
                    bll_user.Call_Insert_User(dto_user);
                    //
                    int id = bll_user.Call_Get_ID_User(txtUsername.Text);
                    b_per.Call_Insert_per(id);
                    MessageBox.Show("successful");
                    this.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
