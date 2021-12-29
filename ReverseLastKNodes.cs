using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AddTwoNumbers;

namespace CrackingTheCodingInterview
{
    internal class ReverseLastKNodes
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null) return head;

            var slow = head;
            var fast = head;
            for (int i = 1; i <= 3; i++)
            {
                fast = fast.next;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            var current = slow.next;
            ListNode prev = null;
            while (current.next != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                next = next.next;
            }
            current.next = prev;

            slow.next = current;

            return head;

        }
    }
}
