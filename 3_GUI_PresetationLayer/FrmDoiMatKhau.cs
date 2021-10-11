using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
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
    public partial class FrmDoiMatKhau : Form
    {
        IBangTamService _Bt;
        IQLNhanVienService _ql;
        List<NhanVien> _lstNhanvien;
        List<BangTam> _lstBangTam;
        BangTam _bangTam;
        NhanVien _nhanVien;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
            _bangTam = new BangTam();
            _ql = new QLNhanVienService();
            _lstNhanvien = new List<NhanVien>();
            _nhanVien = new NhanVien();
            _Bt = new BangTamService();
            _lstBangTam = new List<BangTam>();
            _lstBangTam = _Bt.getBangTam();
            _bangTam = _lstBangTam.FirstOrDefault();
            _lstNhanvien = _ql.getlstNhanVien();           
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (Txt_MatKhauMoi.Text==Txt_XacNhanMK.Text)
            {
                _nhanVien = _lstNhanvien.FirstOrDefault(c => c.MaNv == _bangTam.Manv);
                _nhanVien.MatKhau = Txt_MatKhauMoi.Text;
                _nhanVien.So = 1;
                MessageBox.Show(_ql.ChagePassWord(_nhanVien));
                FrmQLNhanVien frmQLNhanVien = new FrmQLNhanVien();
                this.Hide();
                frmQLNhanVien.Show();
            }
            else
            {
                MessageBox.Show("mật khẩu không trùng khớp", "Thông báo");
            }
            
        }
    }
}
