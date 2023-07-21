using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Xtra
{
    public static class Solution0
    {
        public static void WriteLineFunctions(List<Action> functionsList)
        {
            foreach (Action function in functionsList)
            {
                Console.WriteLine($"\n{function.Method.Name}:");
                function();
            }
        }

        public static void WriteLineClasses(List<Action> classesList)
        {
            foreach (Action function in classesList)
            {
                Console.WriteLine($"\n{function.Method.DeclaringType.Name}:");
                function();
            }
        }

        public static void WriteLineBinaryTrees(TreeNode root)
        {
            if (root != null)
            {
                WriteLineBinaryTrees(root.left);
                Console.Write(" {0} ", root.val);
                WriteLineBinaryTrees(root.right);
            }
        }

        public static void WriteLine<T>(IEnumerable<T> liste)
        {
            string result = "[" + string.Join(", ", liste) + "]";

            Console.WriteLine(result);
        }
    }

    public class ListCountComparer : IComparer<List<int>>
    {
        public int Compare(List<int> x, List<int> y)
        {
            int lengthComparison = x.Count.CompareTo(y.Count);

            if (lengthComparison == 0)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    int elementComparison = x[i].CompareTo(y[i]);
                    if (elementComparison != 0)
                    {
                        return elementComparison;
                    }
                }
            }

            return lengthComparison;
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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
