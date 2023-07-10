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
                SolutionTwoSum.Solution1,
                SolutionAddTwoNumbers.Solution2,
                SolutionPalindromeNumber.Solution9,
                SolutionRomanToInteger.Solution13,
                SolutionLongestCommonPrefix.Solution14,
                SolutionValidParentheses.Solution20,
                SolutionMergeTwoSortedLists.Solution21,
                SolutionRemoveDuplicatesFromSortedArray.Solution26,
                SolutionRemoveElement.Solution27,
                SolutionFindTheIndexOfTheFirstOccurrenceInAString.Solution28,
                SolutionSearchInsertPosition.Solution35,
                SolutionLengthOfLastWord.Solution58,
                SolutionPlusOne.Solution66,
                SolutionAddBinary.Solution67,
                SolutionMinimumSizeSubarraySum.Solution209
            };

            Helper.WriteLineFunctions(functionsList);
        }
    }
}
