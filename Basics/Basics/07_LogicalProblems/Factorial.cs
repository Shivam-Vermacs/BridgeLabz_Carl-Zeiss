using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._07_LogicalProblems
{
    internal class Factorial
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact *= i;

            }
            Console.WriteLine(fact);
        }
    }
}
