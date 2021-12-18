using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeSum first = new ThreeSum();
            var ans = first.Solve(new int[]{ -2,0,0,2,2 });
            Console.WriteLine(ans);       
        }
    }
}
