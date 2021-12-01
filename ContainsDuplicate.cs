using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class ContainsDuplicate
    {
        public bool Contains(int[] nums)
        {
            if (nums.Length < 2) return false;
            HashSet<int> mySet = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (mySet.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    mySet.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
