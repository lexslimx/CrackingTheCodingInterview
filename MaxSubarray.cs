using System;

public class MaxSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {

            if (currentSum + nums[i] > nums[i])
            {
                currentSum = currentSum + nums[i];
            }
            else
            {
                currentSum = nums[i];
            }

            maxSum = Math.Max(currentSum, maxSum);
        }
        return maxSum;
    }
}