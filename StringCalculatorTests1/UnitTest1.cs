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

            Assert.AreEqual(expected, actual, "Method Add with 1,2 string failed");
        }

        [TestMethod]
        public void Add_str_empty()
        {
            string input = "";
            int expected = 0;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with empty string failed");
        }

        [TestMethod]
        public void Add_str_1()
        {
            string input = "1";
            int expected = 1;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with 1 string failed");
        }


        [TestMethod]
        public void Add_str_many_numbers()
        {
            string input = "1, 2, 5, 1, 1, 4";
            int expected = 14;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with many numbers string failed");
        }


        [TestMethod]
        public void Add_str_new_lines_between_numbers()
        {
            string input = "1\n2,3";
            int expected = 6;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with new lines between numbers string failed");
        }
    }
}
