using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_RemoveDuplicatesFromSortedArray
{
    public class Solution26 
    {
        public static void SolutionRemoveDuplicatesFromSortedArray()
        {
            Solution solution = new Solution();

            List<int> result = solution.RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Solution0.WriteLine(result);
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
