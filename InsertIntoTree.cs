using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class InsertIntoTree
    {
        void InsertAfter(TreeNode n, int val)
        {
            //stick it left
            if (n.left == null)
            {
                n.left = new TreeNode(val);
                return;
            }
            else if (n.right == null)
            {
                n.right = new TreeNode(val);
                return;
            }
            else
            {
                InsertAfter(n.right, val);
            }

        }

        void DeleteNode(TreeNode node)
        {
            if (node.left == null && node.right == null) { node = null; }
            else
            {
                if (node.left != null)
                {
                    //recursively swap with predecessor
                    //delete when it gets to be a leaf
                }
            }
        }
    }
}
