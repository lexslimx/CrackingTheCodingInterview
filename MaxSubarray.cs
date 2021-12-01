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

    /**
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentSum = 0;
            int j = i;
            while (j < nums.Length && currentSum + nums[j] >= nums[j])
            {
                currentSum += nums[j];
                j++;
                maxSum = Math.Max(maxSum, currentSum);
                Console.WriteLine(maxSum);
            }
        }

        return maxSum;
    }
    **/
}