using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class HarryAge
    {
        public static void Main(string[] args)
        {
            int birthYear = 2000;
            int currentYear = 2024;
            int age = currentYear - birthYear;
            Console.WriteLine($"Harry's age in {currentYear} is {age}");
        }
    }
}
