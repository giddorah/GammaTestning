using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cardgame.Library;

namespace Cardgame.Tester
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void InputCheckerLongNumber()
        {
            var cardgame = new Library.Library();

            var input = "33c";

            var expectedOutput = false;

            var actualOutput = cardgame.InputChecker(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void InputCheckerShortNumber()
        {
            var cardgame = new Library.Library();

            var input = "ah";

            var expectedOutput = true;

            var actualOutput = cardgame.InputChecker(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void DoesReturnAceOfHearts()
        {
            var cardgame = new Library.Library();

            var input = "ah";

            var expectedOutput = "Ace of Hearts";

            var actualOutput = cardgame.Returner(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
