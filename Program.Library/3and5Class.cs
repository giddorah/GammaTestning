using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Library
{


    // By Michael Åke McClaren Wood




    public class _3and5Class
    {
        
        public bool IfDivisableByThreeAndFive(int input)
        {
            #region Old version
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
#endregion

            // Returns a true-bool if input is divisable by 15.
            return input % 15 == 0;

            #region Alternate version

            // alternative version att metoden anropar de andra två metoderna som skulle då returnera true eller false
            // 
            //return DivisibleBy3(input) && DivisibleBy5(input);
            //

            #endregion
        }
    }
}
