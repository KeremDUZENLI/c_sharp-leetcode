using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoSum
{
    public class SolutionTwoSum
    {
        public static void Solution1()
        {
            Solution solution = new Solution();

            int[] liste = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            Helper.WriteLine(liste);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { };
        }
    }
}
