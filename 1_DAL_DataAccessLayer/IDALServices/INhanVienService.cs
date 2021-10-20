using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public interface INhanVienService
    {
        List<NhanVien> getlstNhanVien();
        string Add(NhanVien nhanVien);
        string Update(NhanVien nhanVien);
        string Delete(NhanVien nhanVien);
        string ChagePassWord(NhanVien nhanVien);
        

    }
}
