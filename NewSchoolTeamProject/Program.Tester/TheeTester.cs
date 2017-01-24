using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Library;

namespace Program.Tester
{





    // By Johan Artur Valentin Spånberg




    [TestClass]
    public class TheeTester
    {
        [TestMethod]
        public void SeeIfReturnsTrueOnCorrectNumbers()
        { // Checks to see if it returns true if number is divisable by three.
            var threeClass = new ThreeClass();

            var input = 3;

            var actualOutput = threeClass.IfDivisableByThree(input);

            Assert.AreEqual(true, actualOutput);
        }

        [TestMethod]
        public void SeeIfReturnsFalseOnOtherNumbers()
        { // Makes sure it does not return true when divisable by three and five.
            var threeClass = new ThreeClass();

            var input = 5;

            var actualOutput = threeClass.IfDivisableByThree(input);

            Assert.AreEqual(false, actualOutput);
        }

        [TestMethod]
        public void SeeWhatReturnsOnZero()
        { // Makes sure it does not return true when divisable by three and five.
            var threeClass = new ThreeClass();

            var input = -1;

            var actualOutput = threeClass.IfDivisableByThree(input);

            Assert.AreEqual(false, actualOutput);
        }
    }
}
