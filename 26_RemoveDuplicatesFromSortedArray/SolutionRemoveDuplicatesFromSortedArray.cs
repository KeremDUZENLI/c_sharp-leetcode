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
