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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        BLL_Users b_user = new BLL_Users();
        private void frm_Login_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (b_user.Call_Get_accuracy(txttk.Text, txtmk.Text))
            {
                frm_Main frmmain = new frm_Main();
                frmmain.Get_name_user(txttk.Text);
                frmmain.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                frmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
