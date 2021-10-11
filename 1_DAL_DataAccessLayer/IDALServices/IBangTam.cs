﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
    public interface IBangTam
    {
        void LuuTam(BangTam bangTam);
        List<BangTam> getBangTam();
        void DeleteBangTam(BangTam bangTam);
    }
}
