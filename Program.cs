using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            TrappingRainWater trappingRainWater = new TrappingRainWater();
            var ans = trappingRainWater.Trap(new int[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1});
            Console.WriteLine(ans);
        }
    }
}
