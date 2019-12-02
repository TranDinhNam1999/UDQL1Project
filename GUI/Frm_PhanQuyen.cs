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
using DTO;
namespace GUI
{
    public partial class Frm_PhanQuyen : Form
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
            InitGridNguoiDung();
            InitGridPhanQuyen("");
            L_per = b_per.Call_class_per();
        }
        public string Users_Name = "";
        BLL_Users b_user = new BLL_Users();
        BLL_Per b_per = new BLL_Per();
        BLL_NhatKiHeThong b_nkht = new BLL_NhatKiHeThong();
        List<DTO_Permission> L_per = new List<DTO_Permission>();
        public void Get_name_user(string name)
        {
            Users_Name = name;
        }
        private void btnDongVaitro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_PhanQuyen_Load(object sender, EventArgs e)
        {
        }
        public void InitGridNguoiDung()
        {
            // tạo các cột
            dtgrNguoiDung.Columns.Clear();
            DataGridViewColumn col00 = new DataGridViewTextBoxColumn();
            col00.Name = "id";
            col00.HeaderText = "id";
            col00.Width = 50;
            dtgrNguoiDung.Columns.Add(col00);
            DataGridViewColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "tentk";
            col0.HeaderText = "Tên Tài khoản";
            col0.Width = 300;
            dtgrNguoiDung.Columns.Add(col0);
            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "hoten";
            col1.HeaderText = "Họ Tên";
            col1.Width = 300;
            dtgrNguoiDung.Columns.Add(col1);
            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "email";
            col2.HeaderText = "Email";
            col2.Width = 300;
            dtgrNguoiDung.Columns.Add(col2);
            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "ngaysinh";
            col3.HeaderText = "Ngày Sinh";
            col3.Width = 250;
            dtgrNguoiDung.Columns.Add(col3);
            //
            DataTable dt = new DataTable();
            dt = b_user.Call_Select_user();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["f_ID"].ToString();
                string tentk = dt.Rows[i]["f_Username"].ToString();
                string hoten= dt.Rows[i]["f_Name"].ToString();
                string email = dt.Rows[i]["f_Email"].ToString();
                string ngaysinh = dt.Rows[i]["f_DOB"].ToString();
                dtgrNguoiDung.Rows.Add(id, tentk, hoten, email, ngaysinh);
            }
            //
        }
        public void InitGridPhanQuyen(string name_user)
        {
            // tạo các cột
            dtgridPhanQuyen.Columns.Clear();
            DataGridViewColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "tentk";
            col0.HeaderText = "Tên Tài khoản";
            col0.Width = 200;
            dtgridPhanQuyen.Columns.Add(col0);
            DataGridViewColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Name = "hethong";
            col1.HeaderText = "Hệ Thống";
            col1.Width = 140;
            dtgridPhanQuyen.Columns.Add(col1);
            DataGridViewColumn col2 = new DataGridViewCheckBoxColumn();
            col2.Name = "danhmuc";
            col2.HeaderText = "Danh Mục";
            col2.Width = 140;
            dtgridPhanQuyen.Columns.Add(col2);
            DataGridViewColumn col3 = new DataGridViewCheckBoxColumn();
            col3.Name = "chucnang";
            col3.HeaderText = "Chức Năng";
            col3.Width = 140;
            dtgridPhanQuyen.Columns.Add(col3);
            DataGridViewColumn col4 = new DataGridViewCheckBoxColumn();
            col4.Name = "trogiup";
            col4.HeaderText = "Trợ Giúp";
            col4.Width = 140;
            dtgridPhanQuyen.Columns.Add(col4);
            DataGridViewColumn col5 = new DataGridViewCheckBoxColumn();
            col5.Name = "them,";
            col5.HeaderText = "Thêm";
            col5.Width = 140;
            dtgridPhanQuyen.Columns.Add(col5);
            DataGridViewColumn col6 = new DataGridViewCheckBoxColumn();
            col6.Name = "xoa";
            col6.HeaderText = "Xoá";
            col6.Width = 145;
            dtgridPhanQuyen.Columns.Add(col6);
            DataGridViewColumn col7 = new DataGridViewCheckBoxColumn();
            col7.Name = "sua";
            col7.HeaderText = "Sửa";
            col7.Width = 150;
            dtgridPhanQuyen.Columns.Add(col7);
            //
            for (int i = 0; i < L_per.Count; i++)
            {
                if (L_per[i].Username == name_user)
                {
                    bool ht = false, dm = false, cn = false, tg = false, t = false, x = false, s = false;
                    if (L_per[i].RW_HeThong == "True") ht = true;
                    if (L_per[i].RW_DanhMuc == "True") dm = true;
                    if (L_per[i].RW_ChungNang == "True") cn = true;
                    if (L_per[i].RW_TroGiup == "True") tg = true;
                    if (L_per[i].Add == "True") t = true;
                    if (L_per[i].Del == "True") x = true;
                    if (L_per[i].Insert == "True") s = true;
                    dtgridPhanQuyen.Rows.Add(L_per[i].Username, ht, dm, cn, tg, t, x, s);
                    dtgridPhanQuyen.Refresh();
                }
            }
            //
        }
        private void dtgrNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgrNguoiDung.SelectedCells.Count > 0)
            {
                int y = dtgrNguoiDung.SelectedCells[0].RowIndex;
                string sss = dtgrNguoiDung.Rows[y].Cells[1].Value.ToString();
                InitGridPhanQuyen(sss);
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, this.Text, btnThemNguoiDung.Text);
            //
            frm_Register frmR = new frm_Register();
            frmR.ShowDialog();
            InitGridNguoiDung();
            InitGridPhanQuyen("");
            this.Refresh();
            dtgrNguoiDung.Refresh();
            dtgridPhanQuyen.Refresh();
            Application.DoEvents();
        }

        private void btnSuaVaiTro_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, this.Text, btnSuaVaiTro.Text);
            //
            int index = dtgrNguoiDung.CurrentRow.Index;
            string s = dtgrNguoiDung.Rows[index].Cells[1].Value.ToString();
            frm_ThemQuyenHan frmTQH = new frm_ThemQuyenHan();
            frmTQH.Get_username_To_from(s);
            frmTQH.ShowDialog();
            InitGridNguoiDung();
            InitGridPhanQuyen("");
            this.Refresh();
            dtgrNguoiDung.Refresh();
            dtgridPhanQuyen.Refresh();
            Application.DoEvents();
        }

        private void btnThemPhanQuyen_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, this.Text, btnThemPhanQuyen.Text);
            //
            frm_ThemQuyenHan frmTQH = new frm_ThemQuyenHan();
            frmTQH.ShowDialog();
            InitGridNguoiDung();
            InitGridPhanQuyen("");
            this.Refresh();
            dtgrNguoiDung.Refresh();
            dtgridPhanQuyen.Refresh();
            Application.DoEvents();
        }

        private void btnXoaVaiTro_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, this.Text, btnXoaVaiTro.Text);
            //
            int index = dtgrNguoiDung.CurrentRow.Index;
            string s = dtgrNguoiDung.Rows[index].Cells[1].Value.ToString();
            int id = int.Parse(dtgrNguoiDung.Rows[index].Cells[0].Value.ToString());
            //code here
            DialogResult d;
            d = MessageBox.Show("Bạn có chắc muốn xoá tài khoản này "+s+" không" , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                b_per.Call_Delete_per(id);
                b_user.Call_Delete_Users(id);
            }
            //
            InitGridNguoiDung();
            InitGridPhanQuyen("");
            this.Refresh();
            dtgrNguoiDung.Refresh();
            dtgridPhanQuyen.Refresh();
            Application.DoEvents();
        }
    }
}
