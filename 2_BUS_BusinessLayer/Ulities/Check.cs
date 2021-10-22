using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Ulities
{
    public class Check:ICheck
    {
      
        

        bool ICheck.CheckString(string intput)
        {
            foreach (var x in intput)
            {
                if (!char.IsDigit(x))
                {
                    return false;
                }
            }
            return true;
        }

        bool ICheck.CheckNumber(string intput)
        {
            foreach (var x in intput)
            {
                if (!char.IsDigit(x))
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckNull(string input)
        {
            if (input==null)
            {
                return false;
            }
            return true;
        }
    }
}
