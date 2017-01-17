using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Library
{
    public class ProgramLibrary
    {
        public void ResultPrinter()
        {
            var _3and5class = new _3and5Class();
            var threeCLass = new ThreeClass();
            var fiveClass = new FiveClass();

            for (int i = 1; i < 101; i++)
            {
                if(_3and5class.CheckIfDivisibleBy3And5(i))
                {
                    Console.WriteLine("Cocacola");
                }
                else if (threeCLass.ThreeReturner(i))
                {
                    Console.WriteLine("Coca");
                }
                else if (fiveClass.CheckIfDevidableBy5(i))
                {
                    Console.WriteLine("Cola");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
