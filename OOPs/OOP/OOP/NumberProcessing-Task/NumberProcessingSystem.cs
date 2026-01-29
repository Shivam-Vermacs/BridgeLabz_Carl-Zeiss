using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.NumberProcessing_Task
{
    internal class NumberProcessingSystem
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

                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= 0)
                        count++;
                }


                int[] result = new int[count];
                int index = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] >= 0)
                    {
                        result[index] = numbers[i];
                        index++;
                    }
                }

                return result;
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
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
