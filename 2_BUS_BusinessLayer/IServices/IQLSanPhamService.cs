using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IQLSanPhamService
    {
        List<Hang> getlstSanPham();
        string Add(Hang hang);
        string Update(Hang hang);
        string Delete(Hang hang);
    }
}
