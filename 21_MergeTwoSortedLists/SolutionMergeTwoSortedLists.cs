using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MergeTwoSortedLists
{
    public class SolutionMergeTwoSortedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode()
            {
                val = 0;
                next = null;
            }

            public ListNode(int x)
            {
                val = x;
                next = null;
            }

            public ListNode(int x, ListNode next)
            {
                val = x;
                this.next = next;
            }
        };

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode liste;

            if (list1 == null)
                return list2;

            if (list2 == null)
                return list1;

            if (list1.val < list2.val)
            {
                liste = list1;
                liste.next = MergeTwoLists(list1.next, list2);
            }
            else
            {
                liste = list2;
                liste.next = MergeTwoLists(list1, list2.next);
            }

            return liste;
        }
    }
}
