using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Kata_1___String_Calculator;

namespace StringCalculatorTests1
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_str_1_2()
        {
            string input = "1,2";
            int expected = 3;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add failed");
        }

        [TestMethod]
        public void Add_str_empty()
        {
            string input = "";
            int expected = 0;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add failed");
        }
    }
}