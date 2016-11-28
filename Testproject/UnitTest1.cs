using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime;
using GammaProjekt;

namespace Testproject
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void SquareRootTest()
        {
            // Create an instance to test:  
            Runtime runtime = new Runtime();
            // Define a test input and output value:  
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            // Run the method under test:  
            double actualResult = runtime.SquareRoot(input);
            // Verify the result:  
            Assert.AreEqual(expectedResult, actualResult,
                delta: expectedResult / 100);
        }
    }
}

