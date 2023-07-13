using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_RemoveDuplicatesFromSortedList
{
    public class Solution83
    {
        public static void RemoveDuplicatesFromSortedList()
        {
            ListNode liste = new ListNode(1);
            liste.next = new ListNode(2);
            liste.next.next = new ListNode(2);
            liste.next.next.next = new ListNode(3);

            Solution solution = new Solution();
            liste = solution.DeleteDuplicates(liste);

            while (liste != null)
            {
                Console.Write(liste.val + " ");
                liste = liste.next;
            }

            Console.WriteLine();
        }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode listNew = new ListNode(0);
            listNew.next = head;

            ListNode current = listNew;

            while (current.next != null && current.next.next != null)
            {
                if (current.next.val == current.next.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return listNew.next;
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
