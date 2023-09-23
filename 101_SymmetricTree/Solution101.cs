using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_SymmetricTree
{
    public class Solution101
    {
        public static void SymmetricTree()
        {
            TreeNode treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.right = new TreeNode(2);

            treeNode.left.left = new TreeNode(3);
            treeNode.left.right = new TreeNode(4);

            treeNode.right.left = new TreeNode(4);
            treeNode.right.right = new TreeNode(3);


            Solution solution = new Solution();
            bool result = solution.IsSymmetric(treeNode);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            List<int> ListeLeft = new List<int>();
            List<int> ListeRight = new List<int>();

            XLeft(root, ListeLeft);
            XRight(root, ListeRight);

            return ListeLeft.SequenceEqual(ListeRight); ;
        }

        public void XLeft(TreeNode node, List<int> Liste)
        {
            if (node == null)
            {
                Liste.Add(5);
                return;
            }

            Liste.Add(node.val);
            XLeft(node.left, Liste);
            XLeft(node.right, Liste);
        }

        public void XRight(TreeNode node, List<int> Liste)
        {
            if (node == null)
            {
                Liste.Add(5);
                return;
            }

            Liste.Add(node.val);
            XRight(node.right, Liste);
            XRight(node.left, Liste);
        }
    }
}
