﻿using System;
using System.Collections.Generic;

namespace _14_LongestCommonPrefix
{
    public class Solution14 
    {
        public static void LongestCommonPrefix()
        {
            Solution solution = new Solution();

            string result = solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return string.Empty;
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }
    }
}
