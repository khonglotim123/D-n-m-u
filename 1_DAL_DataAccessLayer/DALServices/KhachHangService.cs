using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class KhachHangService : IKhachHangService
    {
        DatabaseContext _dbContext;
        public KhachHangService()
        {
            _dbContext = new DatabaseContext();
        }
        public string Add(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Add(khachHang);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }

        public string Delete(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }

        public List<KhachHang> getlstKhachHang()
        {
            return _dbContext.KhachHangs.ToList();
        }        

        public string Update(KhachHang khachHang)
        {
            _dbContext.KhachHangs.Update(khachHang);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
    }
}
