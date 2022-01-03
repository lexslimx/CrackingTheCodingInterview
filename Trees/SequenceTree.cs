using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Trees
{
    internal class SequenceTree
    {
        AugTreeNode tree;
        public SequenceTree()
        {
            tree = new AugTreeNode(7);
            tree.Left = new AugTreeNode(5);
            tree.Right = new AugTreeNode(12);
        }
    }
}
