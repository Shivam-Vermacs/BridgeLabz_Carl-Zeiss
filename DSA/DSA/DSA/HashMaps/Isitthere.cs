using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashMaps
{
    internal class Isitthere
    {
        /*Given an integer array nums and a target integer k, return true if k exists in the array, and false otherwise. Use a HashSet to perform the check.

        Example: nums = [5, 10, 15], k = 10 → Output: true

        Constraint: You must add all elements to a HashSet first.*/

        class Program
        {
            public static void Main(string[] args)
            {
                int[] arr = { 1, 3, 5, 7, 9 };
                int target = 10;

                bool check = CheckIfItExists(arr, target);
                Console.WriteLine($"Does the target exists? {check}");

            }

            public static bool CheckIfItExists(int[] arr,int target)
            {
                HashSet<int> ex = new HashSet<int>();
                for(int i = 0; i < arr.Length; i++)
                {
                    ex.Add(arr[i]);
                }
                bool exist = ex.Contains(target);
                return exist;
            }
        }
    }
}
