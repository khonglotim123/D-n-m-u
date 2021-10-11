using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class QLSanPhamService : IQLSanPhamService
    {
        ISanPhamService _sp;
        public QLSanPhamService()
        {
            _sp = new SanPhamService();
        }
        public string Add(Hang hang)
        {
            return _sp.Add(hang);
        }

        public string Delete(Hang hang)
        {
            return _sp.Delete(hang);
        }

        public List<Hang> getlstSanPham()
        {
            return _sp.getlstSanPham();
        }

        public string Update(Hang hang)
        {
            return _sp.Update(hang);
        }
    }
}
