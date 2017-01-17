using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Library
{
    public class _3and5Class
    {

        public bool CheckIfDivisibleBy3And5(int input)
        {
            //return true;

            //if (input == 15)
            //    return true;
            //else return false;

            //if (input % 5 == 0)
            //    return true;
            //else return false;

            //if (input % 5 == 0 && input % 3 == 0)
            //{
            //    return true;
            //}
            //else return false;

            return input % 15 == 0;

            // alternative version att metoden anropar de andra två metoderna som skulle då returnera true eller false
            // if (DivisibleBy3 && DivisibleBy5)
            //{
            //    return DivisibleBy3(input) && DivisibleBy5(input);
            //}
            //else return false;
        }
    }
}
