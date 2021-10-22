using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.Ulities;
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
        ICheck _check;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
            _bangTam = new BangTam();
            _ql = new QLNhanVienService();
            _lstNhanvien = new List<NhanVien>();
            _nhanVien = new NhanVien();
            _check = new Check();
            _Bt = new BangTamService();
            _lstBangTam = new List<BangTam>();
            _lstBangTam = _Bt.getBangTam();
            _bangTam = _lstBangTam.FirstOrDefault();
            _lstNhanvien = _ql.getlstNhanVien();           
        }

        private void Btn_XacNhan_Click(object sender, EventArgs e)
        {
            //if (_check.CheckNull(Txt_MatKhauMoi.Text)==false || _check.CheckNull(Txt_XacNhanMK.Text) == false)
            //{
            //    MessageBox.Show("Không được để trống");
            //    return;
            //}
            if (Txt_MatKhauMoi.Text==Txt_XacNhanMK.Text)
            {
                _nhanVien = _lstNhanvien.FirstOrDefault(c => c.MaNv == _bangTam.Manv);
                _nhanVien.MatKhau =CreateMD5(Txt_MatKhauMoi.Text);
                _nhanVien.So = 1;
                MessageBox.Show("đổi mật khẩu thành công",_ql.ChagePassWord(_nhanVien));
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("mật khẩu không trùng khớp", "Thông báo");
            }
            
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            frmDangNhap.Show();
        }
    }
}
