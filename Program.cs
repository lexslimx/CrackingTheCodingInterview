using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductOfArrayExceptSelf first = new ProductOfArrayExceptSelf();
            var ans = first.ProductExceptSelf(new int[]{ -1,1,0,-3,3 });
            Console.WriteLine(ans);       
        }
    }
}
