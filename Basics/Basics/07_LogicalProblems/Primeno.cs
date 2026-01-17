using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._07_LogicalProblems
{
    internal class Primeno
    {
        public static void Main()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 2;i< num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
