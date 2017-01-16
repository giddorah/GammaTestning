using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Three.Library;

namespace JS.Tester
{
    [TestClass]
    public class ThreeTester
    {
        [TestMethod]
        public void TestReturnCoca()
        {
            ThreeLibrary threeLibrary = new ThreeLibrary();

            var input = 3;

            var expectedOutput = "coca";

            var actualOutput = threeLibrary.ThisMethodReturnsCoca(input);

            Assert.AreEqual(expectedOutput, actualOutput);  
        }

        [TestMethod]
        public void TestReturnNothingOnDividableOnThreeAndFive()
        {
            ThreeLibrary threeLibrary = new ThreeLibrary();

            var input = 15;

            var expectedOutput = "";

            var actualOutput = threeLibrary.ThisMethodReturnsCoca(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestReturnNothingOnOthers()
        {
            ThreeLibrary threeLibrary = new ThreeLibrary();

            var input = 5;

            var expectedOutput = "";

            var actualOutput = threeLibrary.ThisMethodReturnsCoca(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
