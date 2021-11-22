/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. 
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/
public class AddTwoNumbers
{
    public ListNode Add(ListNode l1, ListNode l2)
    {
        var a = l1;
        var b = l2;
        ListNode c = new ListNode(0, null);
        var ans = c;

        int carry = 0;
        while (a != null && b != null)
        {
            int sum = a.val + b.val + carry;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum - 10;
            }
            else
            {
                carry = 0;
            }

            ans.next = new ListNode(sum);
            ans = ans.next;
            a = a.next;
            b = b.next;
        }

        while (a != null)
        {
            int sum = carry + a.val;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum - 10;
            }
            else
            {
                carry = 0;
            }


            ans.next = new ListNode(sum);
            ans = ans.next;
            a = a.next;
        }

        while (b != null)
        {
            int sum = carry + b.val;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum - 10;
            }
            else
            {
                carry = 0;
            }

            ans.next = new ListNode(sum);
            ans = ans.next;
            b = b.next;
        }

        if (carry == 1)
        {
            ans.next = new ListNode(carry);
        }

        return c.next;
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}