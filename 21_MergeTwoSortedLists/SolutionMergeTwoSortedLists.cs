﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MergeTwoSortedLists
{
    public class SolutionMergeTwoSortedLists
    {
        public static void Solution21()
        {
            ListNode liste1 = new ListNode();
            liste1.val = 1;
            liste1.next = new ListNode(2);
            liste1.next.next = new ListNode(4);

            ListNode liste2 = new ListNode();
            liste2.val = 1;
            liste2.next = new ListNode(3);
            liste2.next.next = new ListNode(4);


            Solution solution = new Solution();
            ListNode result = solution.MergeTwoLists(liste1, liste2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }

            Console.WriteLine();
        }
    }

    public class Solution
    {
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
}
