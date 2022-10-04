using System;

namespace TDD_Kata_1___String_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator ins = new StringCalculator();
            int result = ins.Add("3, 7");
            result = ins.Add("3, 7, 4");
            result = ins.Add("1, 1, 1, 1, 1, 1");
            result = ins.Add("1, 3");
            result = ins.Add("3");
            result = ins.Add("7");
            result = ins.Add("");

            //Console.WriteLine(result);

        }
    }
}
