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
            
            double expectedResult = 2 + 5 ;

            double actualResults = runtime.Addition(2, 5);

            Assert.AreEqual(expectedResult, actualResults);
        }

        [TestMethod]
        public void SubtractionTest()
        {
           
            double expectedResult = 4;

            double actualResults = runtime.Subtraction(7, 3);

            Assert.AreEqual(expectedResult, actualResults);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            
            double expectedResult = 21;

            double actualResults = runtime.Multiplication(7, 3);

            Assert.AreEqual(expectedResult, actualResults);
        }

        [TestMethod]
        [Timeout(500)]
        public void DivisionTest1()
        {

            double expectedResult = 7/3;

            double actualResults = runtime.Division(7,3);

            Assert.AreEqual(expectedResult, actualResults);

            // It works to have several tests in the same testmethod.
            // If there is an error it will be searchable through the output of the test.
            
            expectedResult = 1; // This will cause an error (just for show). Change to a 0 to pass test.

            actualResults = runtime.Division(7,0);
            Assert.AreEqual(expectedResult, actualResults);

            
            expectedResult = 0;

            actualResults = runtime.Division(0, 5);
            Assert.AreEqual(expectedResult, actualResults);
        }

        //[TestMethod]
        //[Timeout(500)]
        //public void DivisionByZero()
        //{
        //    double inputOne = 7;
        //    double inputTwo = 0;
        //    double expectedResult = 0;
            

        //    double actualResults = runtime.Division(inputOne, inputTwo);
        //    Assert.AreEqual(expectedResult, actualResults);
        //}
        //[TestMethod]
        //[Timeout(500)]
        //public void ZeroDivided()
        //{
            
        //    double inputOne = 0;
        //    double inputTwo = 5;
        //    double expectedResult = 0;

        //    double actualResults = runtime.Division(inputOne, inputTwo);
        //    Assert.AreEqual(expectedResult, actualResults);
        //}

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

