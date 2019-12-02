using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_ThemQuyenHan : Form
    {
        public frm_ThemQuyenHan()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = b_user.Call_Select_user();
            cbThenQuyenHan.DisplayMember = "f_Username";
            cbThenQuyenHan.ValueMember = "f_Username";
            cbThenQuyenHan.DataSource = dt;
        }
        BLL_Users b_user = new BLL_Users();
        BLL_Per b_per = new BLL_Per();
        private void frm_ThemQuyenHan_Load(object sender, EventArgs e)
        {

        }
        public void Get_username_To_from(string s)
        {
            cbThenQuyenHan.Text = s;
        }
        private void cbThenQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbThenQuyenHan.SelectedValue.ToString();
            DataTable dt = b_per.Call_Select_Per(s);
            dtgvThemQuyenHan.DataSource = dt;
        }

        private void btnLuuTQH_Click(object sender, EventArgs e)
        {
            string name = dtgvThemQuyenHan.Rows[0].Cells[0].Value.ToString();
            string hethong = dtgvThemQuyenHan.Rows[0].Cells[1].Value.ToString();
            string danhmuc = dtgvThemQuyenHan.Rows[0].Cells[2].Value.ToString();
            string chucnang = dtgvThemQuyenHan.Rows[0].Cells[3].Value.ToString();
            string trogiup = dtgvThemQuyenHan.Rows[0].Cells[4].Value.ToString();
            string them = dtgvThemQuyenHan.Rows[0].Cells[5].Value.ToString();
            string xoa = dtgvThemQuyenHan.Rows[0].Cells[6].Value.ToString();
            string sua = dtgvThemQuyenHan.Rows[0].Cells[7].Value.ToString();
            int _hethong = 0, _danhmuc = 0, _chucnang = 0, _trogiup = 0, _them = 0, _xoa = 0, _sua = 0;
            if (hethong == "True") _hethong = 1;
            if (danhmuc == "True") _danhmuc = 1;
            if (chucnang == "True") _chucnang = 1;
            if (trogiup == "True") _trogiup = 1;
            if (them == "True") _them = 1;
            if (xoa == "True") _xoa = 1;
            if (sua == "True") _sua = 1;
            int id =  b_user.Call_Get_ID_User(name);
            try
            {
                b_per.Call_Update_Per(id, _hethong, _danhmuc, _chucnang, _trogiup, _them, _xoa, _sua);
                MessageBox.Show("Chỉnh sửa thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            catch
            {

            }
        }

        private void btnDongTQH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
