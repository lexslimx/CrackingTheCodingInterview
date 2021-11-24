using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 Given an array nums of distinct integers, 
 return all the possible permutations. 
 You can return the answer in any order.
 * 
 */

namespace CrackingTheCodingInterview
{
    internal class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Perm(nums.ToList(), nums.Length, result, new List<int>());
            return result;
        }

        private void Perm(List<int> nums,int length, List<IList<int>> result, List<int> temp)
        {
            //start with the base case
            if(temp!=null && temp.Count == length)
            {
                result.Add(temp);
            }
            if (temp == null) temp = new List<int>();
            var l = nums.Count();
            for (int index = 0; index < l; index++)
            {
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
