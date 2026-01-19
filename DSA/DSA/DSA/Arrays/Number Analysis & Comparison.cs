using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Number_Analysis___Comparison
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] integers = new int[size];
            Console.WriteLine("Enter the integers in the array");
            for(int i = 0; i < size; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < size; i++)
            {
                if (integers[i]>0 &&  integers[i]%2==0)
                {
                    Console.WriteLine($"{integers[i]} is Positive and Even");

                }
                else if(integers[i]>0 && integers[i]%2!= 0)
                {
                    Console.WriteLine($"{integers[i]} is Positive and Odd");

                }
                else if(integers[i]<0)
                {
                    Console.WriteLine($"{integers[i]} is Negative");
                }
                else
                {
                    Console.WriteLine($"{integers[i]} is Zero");
                }

            }
        }
    }
}
