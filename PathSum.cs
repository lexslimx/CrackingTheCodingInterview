using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) { return false; }
            if (root.left == null && root.right == null && targetSum == root.val) { return true; }
            else if (root == null && targetSum != 0) { return false; }
            else
            {
                return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
            }
        }
    }
}
