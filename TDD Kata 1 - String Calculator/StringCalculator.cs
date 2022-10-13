using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TDD_Kata_1___String_Calculator
{
    public class StringCalculator
    {
        private int addMethodCounter = 0;
        public event Action<StringCalculator> AddOccured = OnAddOccured;

        public int Add(string numbers)
        {
            AddOccured?.Invoke(this);
            if (numbers.Length == 0) return 0; 
            if (numbers.Contains('-'))
            {
                throw new ArgumentException(($"Negative numbers are not allowed (" + this.GetNegativeNumbers(numbers) + ")").ToString());
            }
            Regex regexNumber = new Regex(@"\d+");
            var positiveNumbers = regexNumber.Matches(numbers).Cast<Match>().Select(m => m.Value).ToArray();
            int result = 0;
            foreach (string num in positiveNumbers)
            {
                result += (Int32.Parse(num) < 1000 ? Int32.Parse(num) : 0);
            }
            return result;
        }

        private static void OnAddOccured(StringCalculator source)
        {
            source.addMethodCounter++;
        }

        private string GetNegativeNumbers(string numbers)
        {
            Regex regex = new Regex(@"-\d+");
            var negativeNumbersArray = regex.Matches(numbers).Cast<Match>().Select(m => m.Value).ToArray();
            string negativeNumberForExceptionMessage = "";
            foreach (string str in negativeNumbersArray)
            {
                negativeNumberForExceptionMessage += str + ", ";
            }
            negativeNumberForExceptionMessage = negativeNumberForExceptionMessage.TrimEnd(',', ' ');
            return negativeNumberForExceptionMessage;
        }

        public int GetCalledCount()
        {
            return addMethodCounter;
        }

    }
}
