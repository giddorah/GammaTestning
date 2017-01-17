using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Library;

namespace Program.Tester
{
    [TestClass]
    public class CocacolaTester
    {
        // test för att se att vid ett number som är delbart med båda så blir det rätt
        [TestMethod]
        public void Test_If_Input_15_Returns_True()
        {
            _3and5Class ccc = new _3and5Class();
            int input = 15;
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 3
        [TestMethod]
        public void Test_If_Input_6_Returns_False()
        {
            _3and5Class ccc = new _3and5Class();
            int input = 6;
            bool expectedOutput = false;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // testar att den funkar med andra rätta svar än bara 15
        [TestMethod]
        public void Test_If_Input_30_Returns_True()
        {
            int input = 30;
            _3and5Class ccc = new _3and5Class();
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 5
        [TestMethod]
        public void Test_If_Input_10_Returns_False()
        {
            _3and5Class ccc = new _3and5Class();
            int input = 10;
            bool expectedOutput = false;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
