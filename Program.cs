using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap maxHeap = new MaxHeap();
            maxHeap.Push(5);
            maxHeap.Push(2);
            maxHeap.Push(6);
            maxHeap.Push(8);
            maxHeap.Push(1);

            MinHeap minHeap = new MinHeap();
            minHeap.Push(5);
            minHeap.Push(2);
            minHeap.Push(6);
            minHeap.Push(8);
            minHeap.Push(1);
        }
    }
}
