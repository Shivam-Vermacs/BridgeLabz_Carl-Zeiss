using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays
{
    internal class Voting_Eligibility_Checker
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ages = new int[size];
            Console.WriteLine("Enter the Ages of the Students");
            for(int i = 0; i < size; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid Age");
                }
                else if (ages[i] >= 18) 
                    {
                        Console.WriteLine($"The student with the {ages[i]} can vote.");
                    }
                else if (ages[i] < 18)
                    {
                        Console.WriteLine($"The student with the ${ages[i]} cannot vote.");
                    }
                }
            }
        }
    }

