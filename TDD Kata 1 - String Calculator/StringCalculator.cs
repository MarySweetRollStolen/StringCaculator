using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Kata_1___String_Calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            char[] separator = { ',', '\n' };
            String[] splitNumbers = numbers.Split(separator);
            int result = 0;
            foreach (string number in splitNumbers)
            {
                result += Int32.Parse(number);
#if DEBUG
                Console.Write("*");
                Console.Write(result);
                Console.Write("*");
#endif
            }
            return result;
        }
    }
}
