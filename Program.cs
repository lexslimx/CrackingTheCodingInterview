using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;
using CrackingTheCodingInterview.Sorting;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort selectionSort = new SelectionSort();
            int[] ans = selectionSort.Sort(new int[] { 7, 6, 5, 4, 3, 2 });

            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine(ans[i]);
            }
            
        }
    }
}
