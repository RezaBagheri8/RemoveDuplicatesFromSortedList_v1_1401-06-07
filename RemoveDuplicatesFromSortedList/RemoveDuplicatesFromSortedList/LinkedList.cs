using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedList
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode node = head;

            while (node.next != null)
            {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }

            return head;
        }
    }
}
