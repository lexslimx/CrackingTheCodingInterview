using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {

            if (root == null) return true;

            int left = GetTreeHeight(root.left);
            int right = GetTreeHeight(root.right);

            if (Math.Abs(right - left) <= 1 && IsBalanced(root.left) && IsBalanced(root.right))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetTreeHeight(TreeNode root)
        {
            if (root == null) return 0;
            var left = GetTreeHeight(root.left);
            var right = GetTreeHeight(root.right);
            return Math.Max(left, right) + 1;
        }
    }
}
