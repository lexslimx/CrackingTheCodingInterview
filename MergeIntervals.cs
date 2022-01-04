using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals;

            List<int[]> result = new List<int[]>();
            Array.Sort(intervals, Compare);

            int[] currentInterval = intervals[0];
            result.Add(currentInterval);

            foreach(int[] interval in intervals)
            {
                int currentStart = currentInterval[0];
                int currentEnd = currentInterval[1];

                int nextStart = interval[0];
                int nextEnd = interval[1];

                if(currentEnd >= nextStart)
                {
                    currentInterval[1] = Math.Max(currentEnd, nextEnd);
                }
                else
                {
                    currentInterval = interval;
                    result.Add(currentInterval);
                }

            }

            return result.ToArray();
        }

        private static int Compare(int[] a, int[] b)
        {
            if (a[0] < b[0])
            {
                return -1;
            }
            else if (a[0] > b[0])
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
