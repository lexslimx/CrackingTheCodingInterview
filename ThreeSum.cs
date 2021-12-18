using System;
using System.Collections.Generic;

public class ThreeSum
{
    public IList<IList<int>> Solve(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        //Find x and Y that numbers add up to zero
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            //find two sum that add up to n
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {

                if (left == i)
                {
                    left++;
                }

                if (right == i)
                {
                    right--;
                }

                if (nums[left] + nums[right] == 0 - nums[i])
                {
                    List<int> ans = new List<int>() { nums[i] };
                    ans.Add(nums[left]);
                    ans.Add(nums[right]);
                    result.Add(ans);
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (nums[left] + nums[right] > 0 - nums[i])
                {
                    right--;
                }
                else if (nums[left] + nums[right] < 0 - nums[i])
                {
                    left++;
                }
                else
                {
                    left++;
                    right--;
                }
            }

        }

        return result;
    }
}