using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    //the next node in Inorder traversal of the Binary Tree
    internal class SuccessorNode
    {

        //if node has a right child return the subtree first node of the right child
        //else walk up the tree (node = node,parent) until we go up a left branch (node = node.parent.left)
            //return node

        TreeNode GetSuccessor(TreeNode node)
        {
            if (node == null) return null;
            if(node.right != null)
            {
                var temp = node;
                while (temp.left != null)
                {
                    temp = temp.left;
                }
                return temp;
            }

            /*
            // step 2 of the above algorithm
            Node p = node.parent;
            while (p != null && node == p.right)
            {
                node = p;
                p = p.parent;
            }
            return p;
            */

            return node;
        }

    }
}
