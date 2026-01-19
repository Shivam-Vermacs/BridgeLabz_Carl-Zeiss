using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class LargestNo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            int max = 0;

            Console.WriteLine("Enter the Elements in the Array");
            for(int i= 0; i<size; i++)
            {
                numbers[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 0; i < size; i++)
            {
                if (numbers[i]>max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Largest Element is : "+max);
        }
    }
}
