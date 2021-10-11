using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3_GUI_PresetationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmDangNhap"))
            {
                FrmDangNhap frmdangnhap = new FrmDangNhap();                
                frmdangnhap.Show();
            }
            else
            {
                Active("FrmDangNhap");
            }
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void Active(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
    }
}
