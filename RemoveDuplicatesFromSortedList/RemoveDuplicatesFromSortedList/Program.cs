using RemoveDuplicatesFromSortedList;

//ListNode f = new ListNode() { val = 3, next = null };
//ListNode e = new ListNode() { val = 3, next = f };
//ListNode d = new ListNode() { val = 3, next = e };
//ListNode c = new ListNode() { val = 2, next = d};
ListNode b = new ListNode() { val = 2, next = null };
ListNode a = new ListNode() { val = 1, next = b };
ListNode head = new ListNode() { val = 1, next = a};

Solution solution = new Solution();
solution.DeleteDuplicates(head);
//while(index > 0)
//{
//    ListNode item = new ListNode();
//    item.val = 1;
//    head.next = item;
//    head = item;
//}