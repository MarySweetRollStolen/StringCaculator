using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

        [TestMethod]
        public void Add_str_begins_with_delimiter()
        {
            string input = "//;\n1;2";
            int expected = 3;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with string begins with delimiter failed");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Negative numbers are not allowed (-2)")]
        public void Add_str_throw_negative_number_exception()
        {
            string input = "//;\n1;-2";
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);
            Assert.Fail("No exception throwing");
        }

        [TestMethod]
        public void Add_str_throw_multiple_negative_number_exception()
        {
            string input = "//;\n-1;-2";
            StringCalculator stringCalculator = new StringCalculator();
            try
            {
                int actual = stringCalculator.Add(input);
                Assert.Fail("No multiple negative exception throwing");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Negative numbers are not allowed (-1, -2)", ex.Message);
            }
        }

        [TestMethod]
        public void GetCalledCount_3_calls_of_method_Add()
        {
            string input = "//;\n1;2";
            StringCalculator stringCalculator = new StringCalculator();
            int result = stringCalculator.Add(input);
            result = stringCalculator.Add(input);
            result = stringCalculator.Add(input);
            int expected = 3;
            int actual = stringCalculator.GetCalledCount();
            Assert.AreEqual(expected, actual, "Method GetCalledCount with 3 calls failed");
        }

        [TestMethod]
        public void Add_str_2_1002_ignore_numbers_bigger_1000()
        {
            string input = "2,1001";
            int expected = 2;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with string 2,1001 failed");
        }

        [TestMethod]
        public void Add_str_delimiter_of_any_length()
        {
            string input = "//[***]\n1***2***3";
            int expected = 6;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with delimiters of any length failed");
        }

        [TestMethod]
        public void Add_str_multiple_delimeters()
        {
            string input = "//[*][%]\n1*2%3";
            int expected = 6;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with multiple delimiters failed");
        }


        [TestMethod]
        public void Add_str_any_delimeters()
        {
            string input = "//[**][%%]\n1**2%%3";
            int expected = 6;
            StringCalculator stringCalculator = new StringCalculator();
            int actual = stringCalculator.Add(input);

            Assert.AreEqual(expected, actual, "Method Add with any delimiters failed");
        }
    }
}
