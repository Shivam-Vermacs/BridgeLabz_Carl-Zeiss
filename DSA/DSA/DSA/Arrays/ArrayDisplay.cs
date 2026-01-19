using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class ArrayDisplay
    {
        public static void Main(string[] args)
        {
            int[] integers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                sum += integers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
