using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_SameTree
{
    public class Solution100
    {
        public static void SameTree()
        {
            TreeNode treeNode1 = new TreeNode(1);
            treeNode1.left = new TreeNode(2);

            TreeNode treeNode2 = new TreeNode(1);
            treeNode1.left = new TreeNode();
            treeNode2.right = new TreeNode(2);

            Solution solution = new Solution();
            bool res = solution.IsSameTree(treeNode1, treeNode2);
            Console.WriteLine(res);
        }
    }

    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            List<int> Liste1 = new List<int>();
            List<int> Liste2 = new List<int>();

            traverse(p, Liste1);
            traverse(q, Liste2);

            if (Liste1.Count != Liste2.Count)
            {
                return false;
            }

            for (int i = 0; i < Liste1.Count; i ++)
            {
                if (Liste1[i] != Liste2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void traverse(TreeNode node, List<int> Liste)
        {
            if (node == null)
            {
                Liste.Add(5);
                return;
            }

            Liste.Add(node.val);
            traverse(node.left, Liste);
            traverse(node.right, Liste);
        }
    }
}
