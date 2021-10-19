using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLNhanVienService
    {
        List<NhanVien> getlstNhanVien();
        string Add(NhanVien nhanVien);
        string Update(NhanVien nhanVien);
        string Delete(NhanVien nhanVien);
        string CreatPassWord(int a);
        void GetLogin(string mnv);
        NhanVien  GetNhanVien();
        string ChagePassWord(NhanVien nhanVien);
        void SendMail(string email, string matkhau);
    }
}
