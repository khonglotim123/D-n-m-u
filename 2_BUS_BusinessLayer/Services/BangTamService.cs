using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.DALService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;

namespace _2_BUS_BusinessLayer.Services
{
    public class BangTamService : IBangTamService
    {
        IBangTam _BT;
        public BangTamService()
        {
            _BT = new BangTam12();
        }

        public void DeleteBangTam(BangTam bangTam)
        {
            _BT.DeleteBangTam(bangTam);
        }

        public List<BangTam> getBangTam()
        {
            return _BT.getBangTam();
        }

        public void LuuTam(BangTam bangTam)
        {
            _BT.LuuTam(bangTam);
        }
    }
}
