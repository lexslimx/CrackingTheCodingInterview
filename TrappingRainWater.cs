using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0) return 0;
            int size = height.Length;
            int[] left = new int[size];
            left[0] = height[0];

            int[] right = new int[size];
            right[size - 1] = height[size - 1];

            int ans = 0;

            for (int i = 1; i < left.Length; i++)
            {
                left[i] = Math.Max(height[i], left[i - 1]);
            }

            for (int i = right.Length - 2; i >= 0; i--)
            {
                right[i] = Math.Max(height[i], right[i + 1]);
            }

            for (int i = 1; i < height.Length - 1; i++)
            {
                var t = Math.Min(left[i], right[i]) - height[i];
                ans += t;
            }

            return ans;
        }
    }
}
