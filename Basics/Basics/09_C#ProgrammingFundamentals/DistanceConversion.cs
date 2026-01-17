using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._09_C_ProgrammingFundamentals
{
    internal class DistanceConversion
    {
        public static void Main(string[] args)
        {
            double km = 10.8;
            double miles = km * 1.6;
            Console.WriteLine($"The distance {km} km in miles is {miles}");
        }
    }
}
