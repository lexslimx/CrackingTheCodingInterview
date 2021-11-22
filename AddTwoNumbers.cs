public class AddTwoNumbers{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var a = l1;
        var b = l2;
        ListNode c = new ListNode(0,null);
        var ans = c;    
    
        
        int carry = 0;
        while(a != null && b != null){
            int sum = a.val + b.val + carry;
            if(sum >= 10){
                carry = 1;
                sum = sum - 10;
            }
            else{
                carry = 0;
            }
            
            
            ans.next = new ListNode(sum);
            ans = ans.next;
            a = a.next;
            b = b.next;
        }
        
        while(a!=null){
            int sum = carry + a.val;
            if(sum >= 10){
                carry = 1;
                sum = sum - 10;
            }
            else{
                carry = 0;
            }
            
            
            ans.next = new ListNode(sum);
            ans = ans.next;
            a = a.next;
        }
        
        while(b!=null){
            int sum = carry + b.val;
            if(sum >= 10){
                carry = 1;
                sum = sum - 10;
            }
            else{
                carry = 0;
            }

            ans.next = new ListNode(sum);
            ans = ans.next;
            b = b.next;
        }
        
        if(carry == 1){
            ans.next = new ListNode(carry);
        }
        
        return c.next;
    }
}