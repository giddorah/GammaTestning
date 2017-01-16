using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three.Library
{
    public class ThreeLibrary
    { // This method checks the input number and returns
        public string ThisMethodReturnsCoca(int input)
        {
            var converted = input.ToString();

            if (input % 3 == 0 && input % 5 == 0)
            {
                return "";
            }
            
            else if (input % 3 == 0)
            {
                return "coca";
            }

            else
            {
                return "";
            }
        }
    }
}
