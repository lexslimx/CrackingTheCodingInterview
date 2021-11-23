using CrackingTheCodingInterview.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode slow = dummy;
            ListNode fast = dummy;


            //MOVE FAST N STEPS AHEAD
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            //move both nodes until fast is null

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            //REMOVE next slow node
            slow.next = slow.next.next;


            return dummy.next;
        }
    }
}
