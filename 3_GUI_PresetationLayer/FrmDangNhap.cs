using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Models;

namespace _3_GUI_PresetationLayer
{
    public partial class FrmDangNhap : Form
    {
        NhanVien _nhanVien;
        IQLNhanVienService _qlNhanVien;
        List<NhanVien> _lstNhanVien;
        IBangTamService _bangTam;
        List<BangTam> _lstBangtam;
        BangTam _Bt;

        public FrmDangNhap()
        {
            InitializeComponent();
            _nhanVien = new NhanVien();
            _Bt = new BangTam();
            _qlNhanVien = new QLNhanVienService();
            _lstNhanVien = new List<NhanVien>();
            _lstNhanVien = _qlNhanVien.getlstNhanVien();
            _bangTam = new BangTamService();
            _lstBangtam = new List<BangTam>();
            _lstBangtam = _bangTam.getBangTam();           

        }       

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < _lstNhanVien.Count; i++)
            {
                if (Cmb_Email.Text == _lstNhanVien[i].Email)
                {
                    _nhanVien = _lstNhanVien[i];                    
                }
            }


            if (Cmb_Email.Text == _nhanVien.Email && Txt_MatKhau.Text == _nhanVien.MatKhau && _nhanVien.TinhTrang == 1 && _nhanVien.TrangThai == 0)
            {
                BangTam bangTam = new BangTam();
                bangTam.Id = _nhanVien.Id;
                bangTam.Manv = _nhanVien.MaNv;
                bangTam.Email = _nhanVien.Email;
                bangTam.DiaChi = _nhanVien.DiaChi;
                bangTam.TenNv = _nhanVien.TeNv;
                bangTam.TinhTrang = _nhanVien.TinhTrang;
                bangTam.So = _nhanVien.So;
                bangTam.TrangThai = _nhanVien.TrangThai;
                bangTam.VaiTro = _nhanVien.VaiTro;
                bangTam.MatKhau = _nhanVien.MatKhau;
                bangTam.NhoMatKhau = Cbx_NhoMatKhau.Checked ? 1 : 0;
                _bangTam.LuuTam(bangTam);
                MessageBox.Show("Đăng nhập thành công");
                if (_nhanVien.So == 0)
                {
                    this.Hide();
                    FrmDoiMatKhau frmDoiMatKhau = new FrmDoiMatKhau();
                    frmDoiMatKhau.Show();
                }
                else if (_nhanVien.So == 1)
                {
                    this.Hide();
                    FrmMain frmMain = new FrmMain();
                    frmMain.Show();
                }
            }
            else if (_nhanVien.TrangThai==1)
            {
                MessageBox.Show("Không có tài khoản này", "Thông báo");
                return;
            }
            else if (_nhanVien.TinhTrang==0)
            {
                
                MessageBox.Show("Tài khoản này không còn hoạt động", "Thông Báo");
                return;
            }
           
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
            }
        }
    }
}
