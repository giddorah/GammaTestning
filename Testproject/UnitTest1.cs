using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime;
using GammaProjekt;

namespace Testproject
{
    [TestClass]
    public class Testing
    {
        // Create an instance to test:  
        Runtime runtime = new Runtime();

        [TestMethod]
        public void AdditionTest()
        {
            double inputOne = 2;
            double inputTwo = 5;
            double expectedResult = inputOne + inputTwo;

            double actualResults = runtime.Addition(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        public void SubtractionTest()
        {
            double inputOne = 7;
            double inputTwo = 3;
            double expectedResult = inputOne - inputTwo;

            double actualResults = runtime.Subtraction(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            double inputOne = 7;
            double inputTwo = 3;
            double expectedResult = inputOne * inputTwo;

            double actualResults = runtime.Multiplication(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        [Timeout(2000)]
        public void DivisionTest1()
        {
            
            double inputOne = 7;
            double inputTwo = 3;
            double expectedResult = inputOne / inputTwo;

            double actualResults = runtime.Division(inputOne, inputTwo);

            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        [Timeout(5000)]
        public void DivisionByZero()
        {
            double inputOne = 7;
            double inputTwo = 0;
            double expectedResult = 0;
            

            double actualResults = runtime.Division(inputOne, inputTwo);
            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        [Timeout(2000)]
        public void ZeroDivided()
        {
            
            double inputOne = 0;
            double inputTwo = 5;
            double expectedResult = 0;

            double actualResults = runtime.Division(inputOne, inputTwo);
            Assert.AreEqual(expectedResult, actualResults);
        }
        [TestMethod]
        public void SquareRootTest()
        {
            // Define a test input and output value:  
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:  
            double actualResult = runtime.SquareRoot(input);
            // Verify the result:  
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

