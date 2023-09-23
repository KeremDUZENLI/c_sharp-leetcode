using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_MinimumDepthOfBinaryTree
{
    public class Solution111
    {
        public static void MinimumDepthOfBinaryTree()
        {
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(9);
            node.right = new TreeNode(20);

            node.right.left = new TreeNode(15);
            node.right.right = new TreeNode(7);


            Solution solution = new Solution();
            int result = solution.MinDepth(node);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Count(root);
        }

        private int Count(TreeNode node)
        {
            if (node == null)
            {
                return int.MaxValue;
            }

            if (node.left == null && node.right == null)
            {
                return 1;
            }

            int leftDepth = Count(node.left);
            int rightDepth = Count(node.right);

            return Math.Min(leftDepth, rightDepth) + 1;
        }
    }
}
