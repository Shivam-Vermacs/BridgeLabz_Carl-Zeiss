using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Revision
{
    internal class Abstraction
    {
        class NumProcessor
        {
            public virtual int[] Process(int[] numbers)
            {
                return numbers;
            }
        }

        class NegativeProcessor : NumProcessor
        {
            public override int[] Process(int[] numbers)
            {
                return Array.FindAll(numbers, n => n >= 0);
            }
        }

        class SquareProcessor : NumProcessor
        {
            public override int[] Process(int[] numbers)
            {
                int[] result = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    result[i] = numbers[i] * numbers[i];
                }
                return result;
            }
        }

        class SortProcessor : NumProcessor
        {
            public override int[] Process(int[] numbers)
            {
                Array.Sort(numbers);
                return numbers;
            }
        }

        class Program
        {
            static void Main()
            {
                int[] input = { -5, 2, -3, 4, 1 };

                NumProcessor processor;

                processor = new NegativeProcessor();
                input = processor.Process(input);

                processor = new SquareProcessor();
                input = processor.Process(input);

                processor = new SortProcessor();
                input = processor.Process(input);

                Console.WriteLine("Final Output:");
                foreach (int n in input)
                {
                    Console.Write(n + " ");
                }
            }
        }
    }
}
