using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.HashMaps
{
    internal class Operations
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();

            // how to add the key value pairs to the dictionary
            //d1.Add(0, "Shivam");
            //d1.Add(1, "Karthikeya");

            for(int i = 0; i < 5; i++)
            {
                string val = $"Student{i+1}";
                d1.Add(i, val);
                Console.WriteLine(d1[i]);
            }
        }
    }
}
