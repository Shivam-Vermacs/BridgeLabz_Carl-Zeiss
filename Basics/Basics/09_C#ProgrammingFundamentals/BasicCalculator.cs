using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class BasicCalculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double add = number1 + number2;
            double sub = number1 - number2;
            double mul = number1 * number2;
            double div = number1 / number2;

            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {add}, {sub}, {mul}, and {div}");
        }
    }
}
