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
            CourseSchedule courseSchedule = new CourseSchedule();
            courseSchedule.CanFinish(8, new int[][] {
                new int[] { 1,0 },
                new int[] { 2,6 },
                new int[] { 1,7 },
                new int[] { 6,4 },
                new int[] { 7,0 },
                new int[] { 0,5 },
            });
        }
    }
}
