using _0_Xtra;
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
using _67_AddBinary;
using _69_Sqrt_x_;
using _70_ClimbingStairs;
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
            Problems();
            Console.ReadLine();
        }

        private static void Problems()
        {
            List<Action> functionsList = new List<Action>()
            {
                Solution1.SolutionTwoSum,
                Solution2.SolutionAddTwoNumbers,
                Solution9.SolutionPalindromeNumber,
                Solution13.SolutionRomanToInteger,
                Solution14.SolutionLongestCommonPrefix,
                Solution20.SolutionValidParentheses,
                Solution21.SolutionMergeTwoSortedLists,
                Solution26.SolutionRemoveDuplicatesFromSortedArray,
                Solution27.SolutionRemoveElement,
                Solution28.SolutionFindTheIndexOfTheFirstOccurrenceInAString,
                Solution35.SolutionSearchInsertPosition,
                Solution58.SolutionLengthOfLastWord,
                Solution66.SolutionPlusOne,
                Solution67.SolutionAddBinary,
                Solution69.SolutionSqrt,
                Solution70.SolutionClimbingStairs,
                Solution209.SolutionMinimumSizeSubarraySum
            };

            Solution0.WriteLineClasses(functionsList);
        }
    }
}
