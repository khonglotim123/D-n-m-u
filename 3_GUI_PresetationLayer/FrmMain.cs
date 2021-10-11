using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _1_DAL_DataAccessLayer.Models;


namespace _3_GUI_PresetationLayer
{
    public partial class FrmMain : Form
    {
        IBangTamService _BT;
        List<BangTam> _lstbangtam;
        BangTam _bangtam;
        public FrmMain()
        {
            InitializeComponent();
            _BT = new BangTamService();
            _bangtam = new BangTam();
            _lstbangtam = new List<BangTam>();
            _lstbangtam = _BT.getBangTam();
            _bangtam = _lstbangtam.FirstOrDefault();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmdangnhap = new FrmDangNhap();
            if (CheckExistForm("FrmDangNhap") == false)
            {
                this.Hide();
                frmdangnhap.Show();
            }
            else if (CheckExistForm("FrmDangNhap") == true)
            {
                frmdangnhap.Activate();
            }
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
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
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_lstbangtam.Count != 0)
            {
                FrmQuanLySanPham frmQuanLySanPham = new FrmQuanLySanPham();
                frmQuanLySanPham.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước","Thông báo");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_lstbangtam.Count != 0 && _bangtam.VaiTro==0)
            {
                FrmQLNhanVien frmQLNhanVien = new FrmQLNhanVien();
                frmQLNhanVien.Show();
            }
            else if (_lstbangtam.Count == 0)
            {
                MessageBox.Show("Bạn cần phải đăng nhập trước", "Thông báo");
            }
            else if (_lstbangtam.Count != 0 && _bangtam.VaiTro == 1)
            {
                MessageBox.Show("Chỉ quản lý mới có thể truy cập","Thông báo");
            }           
            
        }             
        
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_bangtam != null)
                {
                    _BT.DeleteBangTam(_bangtam);
                }
                Application.Exit();
            }
        }
    }
}
