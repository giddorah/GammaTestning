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
        // test för att se att vid ett number som är delbart med båda så blir det rätt
        [Test]
        public void Test_If_Input_15_Returns_Cocacola()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 15;
            string expectedOutput = "Cocacola";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 3
        [Test]
        public void Test_If_Input_6_Returns_An_Empty_String()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 6;
            string expectedOutput = "";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // testar att den funkar med andra rätta svar än bara 15
        [Test]
        public void Test_If_Various_Inputs_Returns_Cocacola(
            [Values ( 30, 45, 60, 120)] int input)
        {
            CocacolaCal ccc = new CocacolaCal();
            string expectedOutput = "Cocacola";
            string actualOutput = ccc.CheckIfDivisibleBy3And5(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 5
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
        // test för att se att vid ett number som är delbart med båda så blir det rätt
        [Test]
        public void Test_If_Input_15_Returns_True()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 15;
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 3
        [Test]
        public void Test_If_Input_6_Returns_False()
        {
            CocacolaCal ccc = new CocacolaCal();
            int input = 6;
            bool expectedOutput = false;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        // testar att den funkar med andra rätta svar än bara 15
        [Test]
        public void Test_If_Various_Inputs_Returns_True(
            [Values(30, 45, 60, 120)] int input)
        {
            CocacolaCal ccc = new CocacolaCal();
            bool expectedOutput = true;
            bool actualOutput = ccc.CheckIfDivisibleBy3And5Version2(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        //test för att see att den inte returnerar Cocacola när numret är bara delbart med 5
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
