using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            MinimumInSortedArray mn = new MinimumInSortedArray();
            var ans = mn.FindMinWithSearch(new int[]{4,5,6,7,0,1,2});
            Console.WriteLine(ans);       
        }
    }
}
