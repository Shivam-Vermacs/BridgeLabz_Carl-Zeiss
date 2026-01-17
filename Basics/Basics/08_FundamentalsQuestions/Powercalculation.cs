using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._08_FundamentalsQuestions
{
    internal class Powercalculation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            double basenum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Exponent");
            double exponum = Convert.ToInt32(Console.ReadLine());

            double power = Math.Pow(basenum, exponum);
            Console.WriteLine("Power = " + power);  

        }
    }
}
