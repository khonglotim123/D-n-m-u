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
    public class BangTam12 : IBangTam
    {
        DatabaseContext _db;
        public BangTam12()
        {
            _db = new DatabaseContext();
        }

        public void DeleteBangTam(BangTam bangTam)
        {
            _db.BangTams.Remove(bangTam);
            _db.SaveChanges();
        }

        public List<BangTam> getBangTam()
        {
            return _db.BangTams.ToList();
            
        }

        public void LuuTam(BangTam bangTam)
        {
            _db.BangTams.Add(bangTam);
            _db.SaveChanges();
            //xem đã update được chưa vậy bạn
        }
    }
}
