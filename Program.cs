using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstUniqueCharacter first = new FirstUniqueCharacter();
            var ans = first.FirstUniqChar("leetcode");
            Console.WriteLine(ans);       
        }
    }
}
