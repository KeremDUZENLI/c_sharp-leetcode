using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_MaximumDepthOfBinaryTree
{
    public class Solution104
    {
        public static void MaximumDepthOfBinaryTree()
        {
            TreeNode treeNode = new TreeNode(3);
            treeNode.left = new TreeNode(9);
            treeNode.right = new TreeNode(20);

            treeNode.right.left = new TreeNode(15);
            treeNode.right.right = new TreeNode(7);


            Solution solution = new Solution();
            int result = solution.MaxDepth(treeNode);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            List<int> liste = new List<int>();
            Count(root, 0, liste);

            return liste.Max();
        }

        private void Count(TreeNode root, int depth, List<int> liste)
        {
            if (root == null)
            {
                return;
            }

            depth++;
            Count(root.left, depth, liste);
            Count(root.right, depth, liste);

            liste.Add(depth);
        }
    }
}
