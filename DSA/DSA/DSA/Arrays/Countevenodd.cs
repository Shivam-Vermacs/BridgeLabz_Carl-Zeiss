using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Countevenodd
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size= Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            int countEven = 0;
            int countOdd = 0;
            Console.WriteLine("Enter the elements of array");
            for(int i =0;i<size;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < size; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;

                }
            }
            Console.WriteLine("Even Count : " + countEven);
            Console.WriteLine("Odd Count : "+ countOdd);

        }
    }
}
