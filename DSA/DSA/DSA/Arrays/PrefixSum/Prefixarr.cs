using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.PrefixSum
{
    internal class Prefixarr
    {
        public static void Main(string[] args)
        {
            int[] arr = { 6, 2, 4, 8, 16 };

            int size = arr.Length;
            int[] prefix = new int[size];
            prefix[0] = arr[0];
            for(int i =1; i < size; i++)
            {
                prefix[i] = prefix[i - 1] + arr[i];
            }
            for(int i = 0; i < size; i++)
            {
                Console.Write(prefix[i]+ " ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum of elements from index 2 to 4 : {prefix[4] - prefix[1]} ");
            Console.WriteLine($"Sum from index 0-3 :{prefix[3]} ");
            Console.WriteLine($"Sum fron 1-3: {prefix[3]-prefix[0]}");
        }
    }
}
