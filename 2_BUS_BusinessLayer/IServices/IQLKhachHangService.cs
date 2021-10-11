using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
   public interface IQLKhachHangService
    {
        List<KhachHang> getlstKhachHang();
        string Add(KhachHang khachHang);
        string Update(KhachHang khachHang);
        string Delete(KhachHang khachHang);
    }
}
