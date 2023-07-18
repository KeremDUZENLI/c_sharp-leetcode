using _0_Xtra;
using _1_TwoSum;
using _100_SameTree;
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
using _67_AddBinary;
using _69_Sqrt_x_;
using _70_ClimbingStairs;
using _83_RemoveDuplicatesFromSortedList;
using _88_MergeSortedArray;
using _9_PalindromeNumber;
using _94_BinaryTreeInorderTraversal;
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
            Problems();
            Console.ReadLine();
        }

        private static void Problems()
        {
            List<Action> functionsList = new List<Action>()
            {
                Solution1.TwoSum,
                Solution2.AddTwoNumbers,
                Solution9.PalindromeNumber,
                Solution13.RomanToInteger,
                Solution14.LongestCommonPrefix,
                Solution20.ValidParentheses,
                Solution21.MergeTwoSortedLists,
                Solution26.RemoveDuplicatesFromSortedArray,
                Solution27.RemoveElement,
                Solution28.FindTheIndexOfTheFirstOccurrenceInAString,
                Solution35.SearchInsertPosition,
                Solution58.LengthOfLastWord,
                Solution66.PlusOne,
                Solution67.AddBinary,
                Solution69.Sqrt,
                Solution70.ClimbingStairs,
                Solution83.RemoveDuplicatesFromSortedList,
                Solution88.MergeSortedArray,
                Solution94.BinaryTreeInorderTraversal,
                Solution100.SameTree,
                Solution209.MinimumSizeSubarraySum
            };

            Solution0.WriteLineClasses(functionsList);
            Console.WriteLine("\n#####     SOLVED: {0}     #####\n", functionsList.Count);
        }
    }
}
