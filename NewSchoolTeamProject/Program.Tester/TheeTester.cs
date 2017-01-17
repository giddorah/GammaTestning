using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Library;

namespace Program.Tester
{
    [TestClass]
    public class TheeTester
    {
        [TestMethod]
        public void SeeIfReturnsTrueOnCorrectNumbers()
        { // Made by JS. Checks to see if it returns true if number is dividable by three.
            var threeClass = new ThreeClass();

            var input = 3;

            var actualOutput = threeClass.threeReturner(input);

            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void SeeIfReturnsFalseOnOtherNumbers()
        { // Made by JS. Makes sure it does not return true when dividable by three and five.
            var threeClass = new ThreeClass();

            var input = 5;

            var actualOutput = threeClass.threeReturner(input);

            Assert.AreEqual(false, actualOutput);
        }
    }
}
