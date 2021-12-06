using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class BinaryTreeLevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            int level = 0;
            LevelOrder(result, root, level);
            return result;
        }

        private void LevelOrder(IList<IList<int>> result, TreeNode node, int level)
        {
            if (node == null) return;
            if (result.Count == level) result.Add(new List<int>() { });
            result[level].Add(node.val);

            LevelOrder(result, node.left, level + 1);
            LevelOrder(result, node.right, level + 1);
        }
    }
}
