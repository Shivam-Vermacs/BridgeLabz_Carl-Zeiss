using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashMaps
{
    internal class UniqueCounter
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int[] arr = { 1, 3, 5, 6,6,7,7,9,10,10,10,10, 89, 21, 94 };

                int count = CountUnique(arr);
                Console.WriteLine($"Number of Unique elements : {count}");

            }

            public static int CountUnique(int[] arr)
            {
                HashSet<int> set = new HashSet<int>();
                
                foreach(int item in arr)
                {
                    set.Add(item);
                }
                int count = set.Count;
                return count;
            }
        }
    }
}
