/*
Given the head of a sorted linked list,
delete all duplicates such that each element 
appears only once. 
Return the linked list sorted as well.
*/

using CrackingTheCodingInterview.Nodes;

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var temp = head;
        while(temp != null && temp.next!=null){
            if(temp.val == temp.next.val){
                temp.next = temp.next.next;
            }
            else{
                temp = temp.next;
            }
        }
        return head;
    }
}