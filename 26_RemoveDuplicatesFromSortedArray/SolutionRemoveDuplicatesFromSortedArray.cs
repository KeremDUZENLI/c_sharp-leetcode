using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_RemoveDuplicatesFromSortedArray
{
    public class SolutionRemoveDuplicatesFromSortedArray
    {
        public static void Solution26()
        {
            Solution solution = new Solution();

            List<int> result = solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Helper.WriteLine(result);
        }
    }

    public class Solution
    {
        public List<int> RemoveDuplicates(int[] nums)
        {
            List<int> liste = new List<int>();
            Array.Sort(nums);
            
            foreach (int i in nums)
            {
                if (!liste.Contains(i))
                {
                    liste.Add(i);
                }
            }

            return liste;
        }
    }
}
