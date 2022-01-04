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
            MajorityElement majorityElement = new MajorityElement();
            majorityElement.GetMajority(new int[] { 6, 5, 5 });
        }
    }
}
