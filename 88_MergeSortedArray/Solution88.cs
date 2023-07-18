using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_MergeSortedArray
{
    public class Solution88
    {
        public static void MergeSortedArray()
        {
            Solution solution = new Solution();
            solution.Merge(new int[] { 1, 2, 3, 4, 5, 0 }, 3, new int[] { 2, 5, 6, 0 }, 3);
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int nums1Len = m - 1;
            int nums2Len = n - 1;
            int total = m + n - 1;

            while (nums1Len >= 0 && nums2Len >= 0)
            {
                if (nums1[nums1Len] > nums2[nums2Len])
                {
                    nums1[total] = nums1[nums1Len];
                    nums1Len--;
                }
                else
                {
                    nums1[total] = nums2[nums2Len];
                    nums2Len--;
                }

                total--;
            }

            while (nums2Len >= 0)
            {
                nums1[total] = nums2[nums2Len];
                nums2Len--;
                total--;
            }

            Solution0.WriteLine(nums1);
        }
    }
}
