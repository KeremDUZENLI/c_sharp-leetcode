using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AddTwoNumbers
{
    public class Solution2 
    {
        public static void SolutionAddTwoNumbers()
        {
            Solution solution = new Solution();

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode final = solution.AddTwoNumbers(l1, l2);

            while (final != null)
            {
                Console.Write(final.val + " ");
                final = final.next;
            }

            Console.WriteLine();
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = new ListNode();
            ListNode listNext = listNode;

            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;
                int digit = sum % 10;

                listNext.next = new ListNode(digit);
                listNext = listNext.next;
            }

            return listNode.next;
        }
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
