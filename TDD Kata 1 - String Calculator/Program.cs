using System;

namespace TDD_Kata_1___String_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator ins = new StringCalculator();
            int result = ins.Add("");
            result = ins.Add("//;\n1;2");


            //Console.WriteLine(result);

        }
    }
}
