using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Library;

namespace Program.Tester
{


    // By Karl Ludwig Kleiser



    [TestClass]
    public class FiveClassTester
    {
        [TestMethod]
        public void TestNumber5InFiveClass()
        {
            var fiveClass = new FiveClass();

            int input = 10;

            bool expectedOutput = true;

            bool actualOutput = fiveClass.IfDivisableByFive(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]

        public void TestNumber7InFiveClass()
        {
            var fiveClass = new FiveClass();

            int input = 7;

            bool expectedOutput = false;

            bool actualOutput = fiveClass.IfDivisableByFive(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
