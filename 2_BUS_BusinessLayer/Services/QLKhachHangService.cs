using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _1_DAL_DataAccessLayer.IDALServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLKhachHangService : IQLKhachHangService
    {
        IKhachHangService _kh;
        public QLKhachHangService()
        {
            _kh = new KhachHangService();
        }
        public string Add(KhachHang khachHang)
        {
            return _kh.Add(khachHang);
        }

        public string Delete(KhachHang khachHang)
        {
            return _kh.Delete(khachHang);
        }

        public List<KhachHang> getlstKhachHang()
        {
            return _kh.getlstKhachHang();
        }        

        public string Update(KhachHang khachHang)
        {
            return _kh.Update(khachHang);
        }
    }
}
