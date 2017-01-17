using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Library
{
    public class FiveClass
    {
        public bool CheckIfDevidableBy5(int input)
        {
            if (input % 5 == 0)
                return true;

            else return false;
        }
    }
}
