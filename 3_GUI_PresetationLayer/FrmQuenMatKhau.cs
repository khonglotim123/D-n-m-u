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
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _lstNhanVien = new List<NhanVien>();
            _nhanVien = new NhanVien();
            _qlNhanVien = new QLNhanVienService();
            _lstNhanVien = _qlNhanVien.getlstNhanVien();
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
            MessageBox.Show(_qlNhanVien.ChagePassWord(_nhanVien),"Thông báo");
            SendMail(_nhanVien.Email, _nhanVien.MatKhau);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            frmDangNhap.Show();
        }
    }
}
