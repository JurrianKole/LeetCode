public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carryOver = 0) 
{
    if (l1 == null && l2 == null && carryOver == 0)
    {
        return null;
    }

    if (l1 == null && l2 == null && carryOver == 1)
    {
        return new ListNode(carryOver);
    }

    var valSum = (l1?.val ?? 0) + (l2?.val ?? 0) + carryOver;

    var sumNode = new ListNode(valSum % 10);
    sumNode.next = AddTwoNumbers(l1?.next, l2?.next, valSum / 10);

    return sumNode;
}
