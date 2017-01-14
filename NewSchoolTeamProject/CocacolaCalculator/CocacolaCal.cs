using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocacolaCalculator
{
    public class CocacolaCal
    {
        public string CheckIfDivisibleBy3And5(int input)
        {
            //return "Cocacola";

            //if (input == 15)
            //    return "Cocacola";
            //else return "";

            //if (input % 5 == 0)
            //    return "Cocacola";
            //else return "";

            if (input % 5 == 0 && input % 3 == 0)
                return "Cocacola";
            else return "";


        }
    }
}
