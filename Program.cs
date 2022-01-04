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
            MergeIntervals mergeIntervals = new MergeIntervals();
            mergeIntervals.Merge(new int[][] { 
                new int[] { 1, 4 },
                new int[] { 0,4 }                
            });
        }
    }
}
