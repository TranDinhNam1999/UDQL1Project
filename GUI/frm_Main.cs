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
    public partial class frm_Main : Form
    {
        public static frm_Main FormInstance;
        public frm_Main()
        {
            FormInstance = this;
            InitializeComponent();
        }
        public string Users_Name = "";
        BLL_Per b_per = new BLL_Per();
        DTO_Permission dto_per = new DTO_Permission();
        BLL_NhatKiHeThong b_nkht = new BLL_NhatKiHeThong();
        private Form IsActive(Type fTye) // kiểm tra xem có hiện thị hay không
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == fTye)
                    return f;
            }
            return null;
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            dto_per = b_per.Call_DTO_Per(Users_Name);
            KT_PhanQuyen(dto_per);
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, "Hệ Thống", "Đăng Nhập");
        }
        private void KT_PhanQuyen(DTO_Permission p)
        {
            if(p.RW_ChungNang == "False")
            {
                tabChucnang.Enabled = false;
            }
            if(p.RW_DanhMuc == "False")
            {
                tabDanhmuc.Enabled = false;
            }
            if (p.RW_HeThong == "False")
            {
                tabHethong.Enabled = false;
            }
            if (p.RW_TroGiup == "False")
            {
                tabtrogiup.Enabled = false;
            }
        }
        public void Get_name_user(string name)
        {
            Users_Name = name;
        }
        private void btnKethuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            frm_ThongTin frmtt = new frm_ThongTin();
            frmtt.ShowDialog();
        }

        private void btnVaitroquyenhan_Click(object sender, EventArgs e)
        {
            Form form = IsActive(typeof(Frm_PhanQuyen)); // kiểm tra xem from có đang show hay không
            if (form == null) // form is not show
            {
                Frm_PhanQuyen frmPQ = new Frm_PhanQuyen(); // khởi tạo from và show ra
                frmPQ.MdiParent = this;
                frmPQ.Get_name_user(Users_Name);
                frmPQ.Show();
            }
            else
            {
                form.Activate(); // nếu from đang show trước đó, thì focus lại
            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, "Bảo Mật", btnDoimatkhau.Text);
            //
            frm_DoiMatKhau frmmk = new frm_DoiMatKhau();
            frmmk.Get_name_user(Users_Name);
            frmmk.ShowDialog();
        }

        private void btnNhatkihethong_Click(object sender, EventArgs e)
        {
            Form form = IsActive(typeof(frm_NhatKiHeThong)); // kiểm tra xem from có đang show hay không
            if (form == null) // form is not show
            {
                frm_NhatKiHeThong frmNKHT = new frm_NhatKiHeThong(); // khởi tạo from và show ra
                frmNKHT.MdiParent = this;
                frmNKHT.Get_name_user(Users_Name);
                frmNKHT.Show();
            }
            else
            {
                form.Activate(); // nếu from đang show trước đó, thì focus lại
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.Show();
            this.Hide();
        }
    }
}
