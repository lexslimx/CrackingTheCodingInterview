using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class ValidateBst
    {
        public bool IsValidBST(TreeNode root)
        {
            double max = double.MaxValue;
            double min = double.MinValue;           
            return Validate(root, min, max);
        }

        private bool Validate(TreeNode root, double min, double max)
        {
            if (root == null) return true;
            if (root.val > max || root.val < min) return false;

            return Validate(root.left, min, root.val) && Validate(root.right, root.val, max);            
        }
    }
}
