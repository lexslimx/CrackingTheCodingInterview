using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class MissingNumber
    {
        public int Missing(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length - 1;
            for (var i = 0; i < nums.Length ; i++)
            {
                if (nums[i] != i) return i;
            }
            return nums.Length;
        }

        //bits - god knows how
        //
        public int MissingNumberBits(int[] nums)
        {
            int total = nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                total ^= i ^ nums[i];
            }
            return total;
        }

        //extra memory
        public int MissingNumberWithHashSet(int[] nums)
        {
            HashSet<int> vs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                vs.Add(nums[i]);
            }


            for (var i = 0; i < nums.Length; i++)
            {
                if (!vs.Contains(i)) return i;
            }

            return -1;
        }

        //gauze's law the sum of natural numbers adding up to n is (n*n -1)/2
        public int MissingNumberMath(int[] nums)
        {
            int sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int n = nums.Length + 1;
            return ((n * (n - 1))) / 2 - sum;            
        }
    }
}

//{0,1,2,3,5}
//1+2+3+4+5=15
//1+2+3+5=11
//15-11=4 = ans
//get sum of all numbers up to n
//get 