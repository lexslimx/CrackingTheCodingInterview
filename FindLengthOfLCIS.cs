using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class FindLengthOfLCIS
    {
        public int FindLength(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int maxLength = 1; //2,3

            int prev = nums[0]; //1,3,5

            var temp = 1; //1,2,3
                          //1,3,5,4,7
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > prev)
                {
                    temp++;
                    prev = nums[i];
                    maxLength = Math.Max(temp, maxLength);
                }
                else
                {
                    maxLength = Math.Max(temp, maxLength);
                    temp = 1;
                    prev = nums[i];
                }
            }

            return maxLength;
        }
    }
}
