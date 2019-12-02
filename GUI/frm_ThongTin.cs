using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ThongTin : Form
    {
        public frm_ThongTin()
        {
            InitializeComponent();
        }
        
        private void frm_ThongTin_Load(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTTok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTTketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
