using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics._05_Iterations
{
    internal class Loops
    {
        public static void Main()
        {
            int j = 1;
            int SUM = 0;
            for(int i= 1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            while( j<=10)
            {
                Console.WriteLine(j);
                j++;
                SUM = SUM + j;
            }
            Console.WriteLine(SUM);

        }
    }
}
