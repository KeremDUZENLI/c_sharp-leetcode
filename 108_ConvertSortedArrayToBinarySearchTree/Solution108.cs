using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_ConvertSortedArrayToBinarySearchTree
{
    public class Solution108
    {
        public static void ConvertSortedArrayToBinarySearchTree()
        {
            Solution solution = new Solution();
            TreeNode result = solution.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
            Solution0.WriteLineBinaryTrees(result);

            Console.WriteLine();
        }
    }

    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return ConvertToBST(nums, 0, nums.Length - 1);
        }

        private TreeNode ConvertToBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;
            TreeNode root = new TreeNode(nums[mid]);

            root.left = ConvertToBST(nums, left, mid - 1);
            root.right = ConvertToBST(nums, mid + 1, right);

            return root;
        }
    }
}
