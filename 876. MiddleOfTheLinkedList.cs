public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
    {
        var fastMoving = head;
        var slowMoving = head;
        
        while (fastMoving?.next != null)
        {
            slowMoving = slowMoving.next;
            fastMoving = fastMoving.next.next;
        }
        
        return slowMoving;
    }
}
