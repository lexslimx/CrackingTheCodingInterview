using CrackingTheCodingInterview.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    internal class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            var temp = head;
            while (temp != null)
            {
                stack.Push(temp.val);
                temp = temp.next;
            }

            var t = head;
            while (t != null && stack.Count > 0)
            {
                if (t.val != stack.Pop()) return false;
                t = t.next;
            }


            return true;
        }
    }
}
