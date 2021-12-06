using CrackingTheCodingInterview.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode less = new ListNode(0);
            ListNode more = new ListNode(0);

            var current = head;
            var l = less;
            var m = more;
            while (current != null)
            {
                if (current.val < x)
                {
                    l.next = new ListNode(current.val);
                    l = l.next;
                }
                else
                {
                    m.next = new ListNode(current.val);
                    m = m.next;
                }
                current = current.next;
            }

            l.next = more.next;

            return less.next;
        }
    }
}
