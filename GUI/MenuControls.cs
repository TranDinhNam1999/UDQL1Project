using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class MenuControls : UserControl
    {
        public MenuControls()
        {
            InitializeComponent();
        }
        BLL_Per b_per = new BLL_Per();
        DTO_Permission d_per = new DTO_Permission();
        public void Get_name_per(string s)
        {
           
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
             

        }

        private void btnKethuc_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            frm_ThongTin frmtt = new frm_ThongTin();
            frmtt.ShowDialog();
        }

        private void btnVaitroquyenhan_Click(object sender, EventArgs e)
        {
            Frm_PhanQuyen frmpq = new Frm_PhanQuyen();
            frmpq.Show();
            Form tmp = this.FindForm();
            tmp.Hide();
        }
    }
}
