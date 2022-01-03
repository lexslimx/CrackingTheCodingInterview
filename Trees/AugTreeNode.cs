using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Trees
{
    public class AugTreeNode
    {
        public AugTreeNode Left { get; set; }
        public AugTreeNode Right { get; set; }
        public int Size { get; set; }
        public int Val { get; set; }
        public AugTreeNode(int val)
        {
            Val = val;
        }
    }
}
