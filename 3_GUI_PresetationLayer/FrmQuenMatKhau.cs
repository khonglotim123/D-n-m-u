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
using _2_BUS_BusinessLayer.Services;
using _2_BUS_BusinessLayer.IServices;
using System.Net.Mail;
using System.Net;

namespace _3_GUI_PresetationLayer
{
    public partial class FrmQuenMatKhau : Form
    {
        List<NhanVien> _lstNhanVien;
        NhanVien _nhanVien;
        IQLNhanVienService _qlNhanVien;
        BangTam _bangtam;
        IBangTamService _BT;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _lstNhanVien = new List<NhanVien>();
            _nhanVien = new NhanVien();
            _qlNhanVien = new QLNhanVienService();
            _lstNhanVien = _qlNhanVien.getlstNhanVien();
            _bangtam = new BangTam();
            _BT = new BangTamService();
            _bangtam = _BT.getBangTam().FirstOrDefault();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void SendMail(string email, string matkhau)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential cred = new NetworkCredential("xagiang43@gmail.com", "t15032002");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("xagiang43@gmail.com");
            msg.To.Add(email);
            msg.Subject = "bạn vừa cập nhập mật khẩu";
            msg.Body = "Mật khẩu mới của anh chị là: " + matkhau;
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _lstNhanVien.Count; i++)
            {
                if (Txt_EmailQMK.Text == _lstNhanVien[i].Email)
                {
                    _nhanVien = _lstNhanVien[i];
                }
            }
            _nhanVien.MatKhau = _qlNhanVien.CreatPassWord(6);
            _nhanVien.So = 0;
            _qlNhanVien.ChagePassWord(_nhanVien);
            SendMail(_nhanVien.Email, _nhanVien.MatKhau);
            _nhanVien.MatKhau = CreateMD5(_nhanVien.MatKhau);
            MessageBox.Show("Đổi mật khẩu thành công", _qlNhanVien.ChagePassWord(_nhanVien));


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
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            frmDangNhap.Show();
        }

        private void FrmQuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_bangtam != null)
                {
                    _BT.DeleteBangTam(_bangtam);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }

            }
        }
    }
}
