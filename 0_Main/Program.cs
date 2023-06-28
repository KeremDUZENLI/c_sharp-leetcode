using _1_TwoSum;
using _13_RomanToInteger;
using _2_AddTwoNumbers;
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
                Solution13
            };

            WriteLine(functionsList);
        }

        private static void WriteLine(List<Action> functionsList)
        {
            foreach (Action function in functionsList)
            {
                Console.WriteLine($"\n{function.Method.Name}:");
                function();
            }
        }

        private static void WriteLineList<T>(IEnumerable<T> liste)
        {
            string result = "[" + string.Join(", ", liste) + "]";

            Console.WriteLine(result);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Solution1()
        {
            SolutionTwoSum solution1 = new SolutionTwoSum();

            int[] liste = solution1.TwoSum(new int[] { 3, 2, 4 }, 6);
            WriteLineList(liste);
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
    }
}
