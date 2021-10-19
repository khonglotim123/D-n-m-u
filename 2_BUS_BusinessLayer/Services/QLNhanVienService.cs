using _1_DAL_DataAccessLayer.DALService;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;



namespace _2_BUS_BusinessLayer.Services
{
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienService _nv;
        NhanVien _nvLuu;
        NhanVienView nhanVienView;
        public QLNhanVienService()
        {
            _nv = new NhanVienService();
            _nvLuu = new NhanVien();
            nhanVienView = new NhanVienView();

        }
        public string Add(NhanVien nhanVien)
        {
            return _nv.Add(nhanVien);
        }

        public string ChagePassWord(NhanVien nhanVien)
        {
            return _nv.ChagePassWord(nhanVien);
        }

        public string CreatPassWord(int a)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < a--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string Delete(NhanVien nhanVien)
        {
            return _nv.Delete(nhanVien);
        }

        public void GetLogin(string mnv)
        {
            _nvLuu = _nv.getlstNhanVien().FirstOrDefault(c => c.MaNv == mnv);
        }

        public List<NhanVien> getlstNhanVien()
        {
            return _nv.getlstNhanVien();
        }

        public NhanVien GetNhanVien()
        {
            return _nvLuu;
        }


        public void SendMail(string email, string matkhau)
        {

            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
            NetworkCredential cred = new NetworkCredential("xagiang43@gmail.com", "t15032002");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("xagiang43@gmail.com");
            msg.To.Add(email);
            msg.Subject = "bạn vừa tạo 1 tài khoản mới";
            msg.Body = "chào anh/chị mật khẩu của anh chị là: " + matkhau;
            client.Credentials = cred;
            client.EnableSsl = true;
            client.Send(msg);
           
        }

        public string Update(NhanVien nhanVien)
        {
            return _nv.Update(nhanVien);
        }


    }
}
