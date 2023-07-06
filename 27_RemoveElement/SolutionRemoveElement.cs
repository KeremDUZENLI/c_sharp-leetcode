﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_RemoveElement
{
    public class SolutionRemoveElement
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