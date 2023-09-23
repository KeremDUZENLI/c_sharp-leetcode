using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94_BinaryTreeInorderTraversal
{
    public class Solution94
    {
        public static void BinaryTreeInorderTraversal()
        {
            Solution solution = new Solution();
            TreeNode treeNode = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            IList<int> result = solution.InorderTraversal(treeNode);

            Solution0.WriteLine(result);
        }
    }

    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            InorderTraversalRecursive(root, result);
            return result;

        }

        private void InorderTraversalRecursive(TreeNode node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversalRecursive(node.left, result);
            result.Add(node.val);
            InorderTraversalRecursive(node.right, result);
        }
    }
}
