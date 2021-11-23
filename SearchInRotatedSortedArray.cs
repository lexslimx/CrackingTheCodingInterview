using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            //Find point of rotation
            int start = FindRotationPoint(nums);
            int right = nums.Length - 1;
            int left = 0;
            //search in the correct half
            if (target >= nums[start] && target <= nums[right])
            {
                left = start;
            }
            else
            {
                right = start;
            }

            //Binary search
            while (left <= right)
            {
                int midPoint = left + (right - left) / 2;                
                if (nums[midPoint] == target) return midPoint;

                if (target < nums[midPoint])
                {
                    right = midPoint - 1;
                }
                else
                {
                    left = midPoint + 1;
                }
            }

            return -1;
        }
        
        //4,5,6,7,8,0,1,2 // t = 3
        public int FindRotationPoint(int[] nums)
        {
            //Find minimum value as rotation point
            int length = nums.Length;
            int left = 0;
            int right = length - 1;
            while (left < right)
            { 
                //have them meet at the index of the smallest element
                int mid = left + (right - left) / 2;
                //determine if it's on left or right side
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}
