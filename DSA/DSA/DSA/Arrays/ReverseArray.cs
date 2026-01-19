using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class ReverseArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the Elements in the Array");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reversed Array");
            for (int i = size-1; i >= 0; i--)
            {
                Console.Write(numbers[i]+" ");

            }
        }
        }
}
