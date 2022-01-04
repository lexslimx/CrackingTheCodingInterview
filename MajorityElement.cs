using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class MajorityElement
    {
        public int GetMajority(int[] nums)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (counter.ContainsKey(nums[i]))
                {
                    counter[nums[i]]++;
                }
                else
                {
                    counter.Add(nums[i], 1);
                }
            }

            double num = (double)nums.Length / 2;
            Console.WriteLine(num);


            foreach (var pair in counter)
            {
                Console.WriteLine(pair.Value);
                if (pair.Value >= num) return pair.Key;
            }

            return -1;
        }
    }
}
