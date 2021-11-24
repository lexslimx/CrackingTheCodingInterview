/*
 * Given a collection of numbers, nums, 
 * that might contain duplicates, 
 * return all possible unique permutations in any order.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class PermutationsTwo
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Perm(nums.ToList(), nums.Length, result, new List<int>());
            return result;
        }

        private void Perm(List<int> nums, int length, List<IList<int>> result, List<int> temp)
        {
            //start with the base case
            if (temp != null && temp.Count == length)
            {
                result.Add(temp);
            }


            if (temp == null) temp = new List<int>();

            var l = nums.Count();
            HashSet<int> set = new HashSet<int>();  
            for (int index = 0; index < l; index++)
            {
                if (set.Contains(nums[index])) continue;
                set.Add(nums[index]);
                var num = nums[index];
                var remains = nums.ToList();
                remains.RemoveAt(index);
                var t = temp.ToList();
                t.Add(num);
                Perm(remains, length, result, t);
            }
        }
    }
}
