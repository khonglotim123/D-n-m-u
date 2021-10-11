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
            _nvLuu = _nv.getlstNhanVien().FirstOrDefault(c=>c.MaNv==mnv);
        }

        public List<NhanVien> getlstNhanVien()
        {
            return _nv.getlstNhanVien();
        }

        public NhanVien GetNhanVien()
        {
            return _nvLuu;
        }        

        public string SendMail(string from, string to, string body)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("nilusilu3@gmail.com");
            msg.To.Add(from);
            msg.Subject = to;
            msg.Body = body;

            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntcd = new NetworkCredential();
            ntcd.UserName = "nilusilu3@gmail.com";
            ntcd.Password = "";
            smt.Credentials = ntcd;
            smt.EnableSsl = true;
            smt.Port = 587;
            smt.Send(msg);

            return "Đã gửi mật khẩu về email của bạn";
        }

        public string Update(NhanVien nhanVien)
        {
            return _nv.Update(nhanVien);
        }


    }
}
