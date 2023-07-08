﻿using _0_Xtra;
using _1_TwoSum;
using _13_RomanToInteger;
using _14_LongestCommonPrefix;
using _2_AddTwoNumbers;
using _20_ValidParentheses;
using _209_MinimumSizeSubarraySum;
using _21_MergeTwoSortedLists;
using _26_RemoveDuplicatesFromSortedArray;
using _27_RemoveElement;
using _28_FindTheIndexOfTheFirstOccurrenceInAString;
using _35_SearchInsertPosition;
using _58_LengthOfLastWord;
using _66_PlusOne;
using _9_PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Main
{
    class Program
    {

        static void Main(string[] args)
        {
            Functions();
            Console.ReadLine();
        }

        private static void Functions()
        {
            List<Action> functionsList = new List<Action>()
            {
                Solution1,
                Solution2,
                Solution9,
                Solution13,
                Solution14,
                Solution20,
                Solution21,
                Solution26,
                Solution27,
                Solution28,
                Solution35,
                Solution58,
                Solution66,
                Solution209
            };

            Solution.WriteLineFunctions(functionsList);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Solution1()
        {
            SolutionTwoSum solution1 = new SolutionTwoSum();

            int[] liste = solution1.TwoSum(new int[] { 3, 2, 4 }, 6);
            Solution.WriteLine(liste);
        }

        private static void Solution2()
        {
            SolutionAddTwoNumbers solution2 = new SolutionAddTwoNumbers();

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode final = solution2.AddTwoNumbers(l1, l2);

            while (final != null)
            {
                Console.Write(final.val + " ");
                final = final.next;
            }

            Console.WriteLine();
        }

        private static void Solution9()
        {
            SolutionPalindromeNumber solutionPalindromeNumber = new SolutionPalindromeNumber();

            bool result = solutionPalindromeNumber.IsPalindrome(-52225);
            Console.WriteLine(result);
        }

        private static void Solution13()
        {
            SolutionRomanToInteger solutionRomanToInteger = new SolutionRomanToInteger();

            int result = solutionRomanToInteger.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
        }

        private static void Solution14()
        {
            SolutionLongestCommonPrefix solutionLongestCommonPrefix = new SolutionLongestCommonPrefix();

            string result = solutionLongestCommonPrefix.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine(result);
        }

        private static void Solution20()
        {
            SolutionValidParentheses solutionValidParentheses = new SolutionValidParentheses();

            bool result = solutionValidParentheses.IsValid("()[]{}");
            Console.WriteLine(result);
        }

        private static void Solution21()
        {
            SolutionMergeTwoSortedLists.ListNode liste1 = new SolutionMergeTwoSortedLists.ListNode();
            liste1.val = 1;
            liste1.next = new SolutionMergeTwoSortedLists.ListNode(2);
            liste1.next.next = new SolutionMergeTwoSortedLists.ListNode(4);

            SolutionMergeTwoSortedLists.ListNode liste2 = new SolutionMergeTwoSortedLists.ListNode();
            liste2.val = 1;
            liste2.next = new SolutionMergeTwoSortedLists.ListNode(3);
            liste2.next.next = new SolutionMergeTwoSortedLists.ListNode(4);


            SolutionMergeTwoSortedLists solutionMergeTwoSortedLists = new SolutionMergeTwoSortedLists();
            SolutionMergeTwoSortedLists.ListNode result = solutionMergeTwoSortedLists.MergeTwoLists(liste1, liste2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }

            Console.WriteLine();
        }

        private static void Solution26()
        {
            SolutionRemoveDuplicatesFromSortedArray solutionRemoveDuplicatesFromSortedArray = new SolutionRemoveDuplicatesFromSortedArray();

            List<int> result = solutionRemoveDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Solution.WriteLine(result);
        }

        private static void Solution27()
        {
            SolutionRemoveElement solutionRemoveElement = new SolutionRemoveElement();

            int[] result = solutionRemoveElement.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 0);
            Solution.WriteLine(result);
        }

        private static void Solution28()
        {
            SolutionFindTheIndexOfTheFirstOccurrenceInAString solutionFindTheIndexOfTheFirstOccurrenceInAString = new SolutionFindTheIndexOfTheFirstOccurrenceInAString();

            List<char> result = solutionFindTheIndexOfTheFirstOccurrenceInAString.StrStr("leetcode", "etco");
            Solution.WriteLine(result);
        }

        private static void Solution35()
        {
            SolutionSearchInsertPosition solutionSearchInsertPosition = new SolutionSearchInsertPosition();

            int result = solutionSearchInsertPosition.SearchInsert(new int[] { 1 }, 0);
            Console.WriteLine(result);
        }

        private static void Solution58()
        {
            SolutionLengthOfLastWord solutionLengthOfLastWord = new SolutionLengthOfLastWord();

            int result = solutionLengthOfLastWord.LengthOfLastWord("   fly me   to   the moon  ");
            Console.WriteLine(result);
        }

        private static void Solution66()
        {
            SolutionPlusOne solutionPlusOne = new SolutionPlusOne();

            int[] result = solutionPlusOne.PlusOne(new int[] { 9, 9 });
            Solution.WriteLine(result);
        }

        private static void Solution209()
        {
            SolutionMinimumSizeSubarraySum solutionMinimumSizeSubarraySum = new SolutionMinimumSizeSubarraySum();
            int result = solutionMinimumSizeSubarraySum.MinSubArrayLen(214, new List<int> { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 });
            Console.WriteLine(result);
        }

        private static void Solution209_2()
        {
            SolutionMinimumSizeSubarraySum solutionMinimumSizeSubarraySum = new SolutionMinimumSizeSubarraySum();

            List<int> listeSub = new List<int>();
            List<List<int>> listeNew = new List<List<int>>();
            solutionMinimumSizeSubarraySum.ListCreate(new List<int> { 1, 2, 3, 4, 5 }, listeSub, 0, 5, listeNew);
            listeNew.Sort(new ListCountComparer());

            foreach (List<int> x in listeNew)
            {
                Solution.WriteLine(x);
            }
        }
    }
}
