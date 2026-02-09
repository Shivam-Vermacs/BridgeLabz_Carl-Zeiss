using System;
using System.Collections.Generic;

namespace DSA
{
    internal class Handshakes
    {
        private readonly int k;
        private readonly Queue<int> window = new Queue<int>();

        private readonly PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        private readonly PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        private readonly Dictionary<int, int> delayed = new Dictionary<int, int>();

        private int maxHeapSize = 0;
        private int minHeapSize = 0;

        private readonly LinkedList<int> minDeque = new LinkedList<int>();
        private readonly LinkedList<int> maxDeque = new LinkedList<int>();

        public Handshakes(int windowSize = 5)
        {
            k = windowSize;
        }

        public void Insert(int num)
        {
            window.Enqueue(num);

            while (minDeque.Count > 0 && minDeque.Last.Value > num)
                minDeque.RemoveLast();
            minDeque.AddLast(num);

            while (maxDeque.Count > 0 && maxDeque.Last.Value < num)
                maxDeque.RemoveLast();
            maxDeque.AddLast(num);

            CleanHeap(maxHeap);
            CleanHeap(minHeap);

            if (maxHeap.Count == 0 || num <= maxHeap.Peek())
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
                int oldest = window.Dequeue();
                Remove(oldest);
            }
        }

        private void Remove(int num)
        {
            if (minDeque.Count > 0 && minDeque.First.Value == num)
                minDeque.RemoveFirst();
            if (maxDeque.Count > 0 && maxDeque.First.Value == num)
                maxDeque.RemoveFirst();

            if (!delayed.TryGetValue(num, out int cnt))
                delayed[num] = 1;
            else
                delayed[num] = cnt + 1;

            CleanHeap(maxHeap);

            if (maxHeap.Count > 0 && num <= maxHeap.Peek())
                maxHeapSize--;
            else
                minHeapSize--;

            CleanHeap(maxHeap);
            CleanHeap(minHeap);
            BalanceHeaps();
        }

        private void CleanHeap(PriorityQueue<int, int> heap)
        {
            while (heap.Count > 0)
            {
                int top = heap.Peek();
                if (delayed.TryGetValue(top, out int count) && count > 0)
                {
                    heap.Dequeue();
                    delayed[top] = count - 1;
                    if (delayed[top] == 0)
                        delayed.Remove(top);
                }
                else
                {
                    break;
                }
            }
        }

        private void BalanceHeaps()
        {
            if (maxHeapSize > minHeapSize + 1)
            {
                CleanHeap(maxHeap);
                int val = maxHeap.Dequeue();
                maxHeapSize--;
                minHeap.Enqueue(val, val);
                minHeapSize++;
            }
            else if (minHeapSize > maxHeapSize)
            {
                CleanHeap(minHeap);
                int val = minHeap.Dequeue();
                minHeapSize--;
                maxHeap.Enqueue(val, -val);
                maxHeapSize++;
            }

            CleanHeap(maxHeap);
            CleanHeap(minHeap);
        }

        public double GetMedian()
        {
            CleanHeap(maxHeap);
            CleanHeap(minHeap);

            if ((maxHeapSize + minHeapSize) % 2 == 1)
                return maxHeap.Peek();

            return ((double)maxHeap.Peek() + minHeap.Peek()) / 2.0;
        }

        public int GetMin()
        {
            return minDeque.First.Value;
        }

        public int GetMax()
        {   
            return maxDeque.First.Value;
        }

        public int[] CurrentWindow()
        {
            return window.ToArray();
        }
    }
}
