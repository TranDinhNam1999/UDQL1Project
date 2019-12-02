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
using System.Data.OleDb;

namespace GUI
{
    public partial class frm_NhatKiHeThong : Form
    {
        BLL_NhatKiHeThong b_nkht = new BLL_NhatKiHeThong();
        public string Users_Name = "";
        public frm_NhatKiHeThong()
        {
            InitializeComponent();
            InitGvNhatKiHeThong();
        }
        public void Get_name_user(string name)
        {
            Users_Name = name;
        }
        private void InitGvNhatKiHeThong()
        {
            dtgvNhatKiHeThong.Columns.Clear();
            DataGridViewColumn col00 = new DataGridViewTextBoxColumn();
            col00.Name = "id";
            col00.HeaderText = "id";
            col00.Width = 50;
            dtgvNhatKiHeThong.Columns.Add(col00);
            DataGridViewColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "nguoidung";
            col0.HeaderText = "Người Dùng";
            col0.Width = 300;
            dtgvNhatKiHeThong.Columns.Add(col0);
            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "time";
            col1.HeaderText = "Thời Gian";
            col1.Width = 300;
            dtgvNhatKiHeThong.Columns.Add(col1);
            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "chucnang";
            col2.HeaderText = "Chức Năng";
            col2.Width = 300;
            dtgvNhatKiHeThong.Columns.Add(col2);
            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "hanhdong";
            col3.HeaderText = "Hành Động";
            col3.Width = 270;
            dtgvNhatKiHeThong.Columns.Add(col3);
            //
            DataTable dt = new DataTable();
            dt = b_nkht.Call_Select_NhatKiHeThong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                string nguoidung = dt.Rows[i]["NguoiDung"].ToString();
                string thoigian = dt.Rows[i]["ThoiGian"].ToString();
                string chucnang = dt.Rows[i]["ChucNang"].ToString();
                string hanhdong = dt.Rows[i]["HanhDong"].ToString();
                dtgvNhatKiHeThong.Rows.Add(id,nguoidung, thoigian, chucnang, hanhdong);
            }
            //
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InitGvNhatKiHeThong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_NhatKiHeThong_Load(object sender, EventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // save nhật kí
            b_nkht.Call_Insert_NhatKiHeThong(Users_Name, this.Text, btnXoa.Text);
            //
            try
            {
                int index = dtgvNhatKiHeThong.CurrentRow.Index;
                int id = int.Parse(dtgvNhatKiHeThong.Rows[index].Cells[0].Value.ToString());
                //code here
                DialogResult d;
                d = MessageBox.Show("Bạn có chắc muốn xoá thông tin này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (d == DialogResult.Yes)
                {
                    b_nkht.Call_Delete_NhatKiHeThong(id);
                }
                //
                InitGvNhatKiHeThong();
                this.Refresh();
                dtgvNhatKiHeThong.Refresh();
                Application.DoEvents();
            }
            catch
            {

            }
        }
        public string pathfile = "";
        private void btnDocTuTapTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathfile = openFileDialog1.FileName;
            }
        }

        private void btnLuuVaoTapTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pathfile);
        }
    }
}
