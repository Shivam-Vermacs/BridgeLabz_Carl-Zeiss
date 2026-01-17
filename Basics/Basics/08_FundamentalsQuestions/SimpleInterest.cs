using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._08_FundamentalsQuestions
{
    internal class SimpleInterest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal :");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate :");
            int Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Time :");
            int Time = Convert.ToInt32(Console.ReadLine());

            int SI = (principal * Rate * Time) / 100;

            Console.WriteLine("Simple Interest : " + SI);
        }
    }
}
