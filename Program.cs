using System;
using CrackingTheCodingInterview.Heap;
using CrackingTheCodingInterview.Nodes;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(2);
            listNode.next.next.next = new ListNode(1);

            var ans = palindromeLinkedList.IsPalindrome(listNode);
        }
    }
}
