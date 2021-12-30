using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Sorting
{
    internal class SelectionSort
    {
        public int[] Sort(int[] nums)
        {
            for(int index = 0; index < nums.Length; index ++)
            {
                int smallest = index;
                //find the largest element to the right of index
                for(int j = index + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[index]) smallest = j;
                }                
                //swap index for largest
                var temp = nums[index];
                nums[index] = nums[smallest];
                nums[smallest] = temp;
            }


            return nums;
        }
    }
}
