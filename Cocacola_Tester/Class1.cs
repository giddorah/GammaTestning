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
    public class TestsForMethodOne
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

    [TestFixture]
    public class TestsForMethodTwo
    {
        [Test]
        public void Test_If_Input_15_Returns_True()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 15;
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_6_Returns_False()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 6;
            bool expectedOutput = false;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_30_Returns_True()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 30;
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Test_If_Input_10_Returns_False()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 10;
            bool expectedOutput = false;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
