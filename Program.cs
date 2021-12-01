using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxSubarray max = new MaxSubarray();
            var ans = max.MaxSubArray(new int[]{-2,1,-3,4,-1,2,1,-5,4});
            Console.WriteLine(ans);
        }
    }
}
