using System;
using System.Collections.Generic;

namespace DSA.Reviewa
{
    internal class Question1
    {
        class SlidingWindowMedian
        {
            private Queue<int> window = new Queue<int>();
            private PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
            private PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
            private Dictionary<int, int> delay = new Dictionary<int, int>();
            private int k = 5;
            private int minHeapSize = 0;
            private int maxHeapSize = 0;

            public void Insert(int num)
            {
                window.Enqueue(num);

                if (maxHeap.Count == 0 || num <= GetMedianValue())
                {
                    maxHeap.Enqueue(num, -num);
                    maxHeapSize++;
                }
                else
                {
                    minHeap.Enqueue(num, num);
                    minHeapSize++;
                }

                BalanceHeaps();

                if (window.Count > k)
                {
                    int toRemove = window.Dequeue();
                    Remove(toRemove);
                }
            }

            private void Remove(int num)
            {
                if (!delay.ContainsKey(num))
                {
                    delay[num] = 0;
                }

                delay[num]++;

                
                if (num <= GetMedianValue())
                {
                    maxHeapSize--;
                }
                else
                {
                    minHeapSize--;
                }

                CleanHeap(maxHeap);
                CleanHeap(minHeap);
                BalanceHeaps();
            }

            private void CleanHeap(PriorityQueue<int, int> heap)
            {
                while (heap.Count > 0)
                {
                    int num = heap.Peek();
                    if (delay.ContainsKey(num) && delay[num] > 0)
                    {
                        heap.Dequeue();
                        delay[num]--;
                        if (delay[num] == 0)
                        {
                            delay.Remove(num);
                        }
                    }
                    else
                        break;
                }
            }

            private void BalanceHeaps()
            {
                if (maxHeapSize > minHeapSize + 1)
                {
                    int val = maxHeap.Dequeue();
                    maxHeapSize--;
                    minHeap.Enqueue(val, val);
                    minHeapSize++;
                }
                else if (minHeapSize > maxHeapSize)
                {
                    int val = minHeap.Dequeue();
                    minHeapSize--;
                    maxHeap.Enqueue(val, -val);
                    maxHeapSize++;
                }
            }

            private int GetMedianValue()
            {
                if (maxHeap.Count == 0 && minHeap.Count == 0)
                    return int.MinValue;
                if (maxHeap.Count == 0)
                    return minHeap.Peek();
                if (minHeap.Count == 0)
                    return maxHeap.Peek();

                return maxHeap.Peek(); 
            }

            public double GetMedian()
            {
                CleanHeap(maxHeap);
                CleanHeap(minHeap);

                if (maxHeapSize == minHeapSize)
                {
                    return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
                }
                else
                {
                    return maxHeap.Peek();
                }
            }

            public int GetMin()
            {
                CleanHeap(maxHeap);
                CleanHeap(minHeap);

                if (maxHeapSize > 0 && minHeapSize > 0)
                {
                    return Math.Min(maxHeap.Peek(), minHeap.Peek());
                }
                else if (maxHeapSize > 0)
                {
                    return maxHeap.Peek();
                }
                else
                {
                    return minHeap.Peek();
                }
            }

            public int GetMax()
            {
                CleanHeap(maxHeap);
                CleanHeap(minHeap);

                if (minHeapSize > 0 && maxHeapSize > 0)
                {
                    return Math.Max(maxHeap.Peek(), minHeap.Peek());
                }
                else if (minHeapSize > 0)
                {
                    return minHeap.Peek();
                }
                else
                {
                    return maxHeap.Peek();
                }
            }

            public List<int> GetWindow()
            {
                return new List<int>(window);
            }
        }

     
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 3, 12, 1, 8, 7, 9 };
            SlidingWindowMedian sw = new SlidingWindowMedian();

            
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                sw.Insert(num);

                Console.WriteLine($"Step {i + 1}: Added {num}");
                Console.WriteLine($"Window: [{string.Join(", ", sw.GetWindow())}]");

                    Console.WriteLine($"Max: {sw.GetMax()}");
                    Console.WriteLine($"Min: {sw.GetMin()}");
                Console.WriteLine($"Median: {sw.GetMedian():F1}");
               
            }

            
            
        }
    }
}
