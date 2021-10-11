using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IKhachHangService
    {
        List<KhachHang> getlstKhachHang();
        string Add(KhachHang khachHang);
        string Update(KhachHang khachHang);
        string Delete(KhachHang khachHang);
    }
}
