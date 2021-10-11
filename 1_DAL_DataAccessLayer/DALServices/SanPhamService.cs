using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.DALServices
{
    public class SanPhamService : ISanPhamService
    {
        DatabaseContext _dbContext;
        public SanPhamService()
        {
            _dbContext = new DatabaseContext();
        }

        public string Add(Hang hang)
        {
            _dbContext.Hangs.Add(hang);
            _dbContext.SaveChanges();
            return "Thêm thành công";
        }

        public string Delete(Hang hang)
        {
            _dbContext.Hangs.Update(hang);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }

        public List<Hang> getlstSanPham()
        {
            return _dbContext.Hangs.ToList();
        }

        public string Update(Hang hang)
        {
            _dbContext.Hangs.Update(hang);
            _dbContext.SaveChanges();
            return "Sửa thành công";
        }
    }
}
