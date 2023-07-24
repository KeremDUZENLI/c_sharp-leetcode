using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110_BalancedBinaryTree
{
    public class Solution110
    {
        public static void Balanced()
        {
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(9);
            node.right = new TreeNode(20);
            node.right.left = new TreeNode(15);
            node.right.right = new TreeNode(7);

            Solution0.WriteLineBinaryTrees(node);
            Console.WriteLine();


            Solution solution = new Solution();
            bool result = solution.IsBalanced(node);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int branchLeft = Depth(root.left);
            int branchRight = Depth(root.right);
            int res = Math.Abs(branchLeft - branchRight);

            return res <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int Depth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int depthLeft = Depth(node.left);
            int depthRight = Depth(node.right);

            return 1 + Math.Max(depthLeft, depthRight);
        }
    }
}
