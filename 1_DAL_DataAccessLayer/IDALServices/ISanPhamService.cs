using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface ISanPhamService
    {
        List<Hang> getlstSanPham();
        string Add(Hang hang);
        string Update(Hang hang);
        string Delete(Hang hang);
    }
}
