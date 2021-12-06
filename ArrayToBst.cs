using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class ArrayToBst
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return AddNode(nums, 0, nums.Length - 1);
        }

        private TreeNode AddNode(int[] nums, int left, int right)
        {
            TreeNode root = null;
            int mid = left + (right - left) / 2;
            if (left <= right)
            {
                root = new TreeNode(nums[mid]);
                root.left = AddNode(nums, left, mid - 1);
                root.right = AddNode(nums, mid + 1, right);
            }
            return root;
        }

    }
}
