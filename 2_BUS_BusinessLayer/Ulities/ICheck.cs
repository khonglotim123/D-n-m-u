using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Ulities
{
    public interface ICheck
    {
        bool CheckNull(string input);
        bool CheckString(string intput);
        bool CheckNumber(string intput);
    }
}
