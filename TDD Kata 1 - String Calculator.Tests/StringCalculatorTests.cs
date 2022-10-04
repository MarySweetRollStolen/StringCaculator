using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace TDD_Kata_1___String_Calculator.Tests
{
    [TestClass]
    class StringCalculatorTests
    {

        [TestMethod]
        public void Add_12()
        {
            string input = "1,2";
            int expected = 3;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add failed");
        }

    }
}
