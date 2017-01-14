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

        [Test]
        public void Test_If_Input_6_Returns_An_Empty_String()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 6;
            string expectedOutput = "";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_30_Returns_An_Cocacola()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 30;
            string expectedOutput = "Cocacola";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_10_Returns_An_Empty_String()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 10;
            string expectedOutput = "";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
