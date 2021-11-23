using System;
using CrackingTheCodingInterview.Heap;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchInRotatedSortedArray searchInRotatedSortedArray = new SearchInRotatedSortedArray();
            var ans = searchInRotatedSortedArray.Search(new int[] { 3,1},1);
            Console.WriteLine(ans);
        }
    }
}
