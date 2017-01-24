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
            // Creates the objects for each control-class
            var checkThreeAndFive = new _3and5Class();
            var checkThree = new ThreeClass();
            var checkFive = new FiveClass();

            // Loops through 1-100
            for (int i = -100; i < 101; i++)
            {
                if(checkThreeAndFive.IfDivisableByThreeAndFive(i))
                { // If i is divisable by three and five, types below:
                    Console.WriteLine("Cocacola");
                }
                else if (checkThree.IfDivisableByThree(i))
                { // If i is divisable by three, types below:
                    Console.WriteLine("Coca");
                }
                else if (checkFive.IfDivisableByFive(i))
                { // If i is divisable by five, types below:
                    Console.WriteLine("Cola");
                }
                else
                { // Else it returns the number value of i:
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
