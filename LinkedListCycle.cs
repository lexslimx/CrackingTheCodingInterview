using System;
using CrackingTheCodingInterview.Nodes;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        if (head == null) return false;
        var slow = head;
        if (head.next == null || head.next.next == null) return false;
        var fast = head.next.next;

        while (slow != fast && fast.next != null && fast.next.next != null)
        {

            fast = fast.next.next;
            slow = slow.next;
        }

        if (fast == slow) return true;

        return false;

    }
}