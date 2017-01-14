using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CocacolaCalculator;
namespace Cocacola_Tester
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_If_Input_15_Returns_Cocacola()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 15;
            string expectedOutput = "Cocacola";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
