using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;

namespace _1_DAL_DataAccessLayer.DALService
{
    public class NhanVienService : INhanVienService
    {
        private DatabaseContext _dbContext;
        public NhanVienService()
        {
            _dbContext = new DatabaseContext();
        }
        public string Add(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Add(nhanVien);
            _dbContext.SaveChanges();
            return null;
        }

        public string ChagePassWord(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);
            _dbContext.SaveChanges();
            return null;
        }

        public string Delete(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);
            _dbContext.SaveChanges();
            return "Xóa thành công";
        }

        public List<NhanVien> getlstNhanVien()
        {
            return _dbContext.NhanViens.ToList();
        }        

        public string Update(NhanVien nhanVien)
        {
            _dbContext.NhanViens.Update(nhanVien);
            _dbContext.SaveChanges();
            return null;
        }
    }
}
