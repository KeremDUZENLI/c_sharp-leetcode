using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_RemoveElement
{
    public class SolutionRemoveElement
    {
        public static void Solution27()
        {
            Solution solution = new Solution();

            int[] result = solution.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 0);
            Helper.WriteLine(result);
        }
    }

    public class Solution
    {
        public int[] RemoveElement(int[] nums, int val)
        {
            int indexNew = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[indexNew] = nums[i];
                    indexNew++;
                }
            }

            int[] numsNew = new int[indexNew];
            Array.Copy(nums, numsNew, indexNew);

            return numsNew;
        }
    }
}
