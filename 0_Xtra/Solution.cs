﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Xtra
{
    public static class Solution
    {
        public static void WriteLine(List<Action> functionsList)
        {
            foreach (Action function in functionsList)
            {
                Console.WriteLine($"\n{function.Method.Name}:");
                function();
            }
        }

        public static void WriteLineList<T>(IEnumerable<T> liste)
        {
            string result = "[" + string.Join(", ", liste) + "]";

            Console.WriteLine(result);
        }
    }

    public class ListCountComparer : IComparer<List<int>>
    {
        public int Compare(List<int> x, List<int> y)
        {
            int lengthComparison = x.Count.CompareTo(y.Count);

            if (lengthComparison == 0)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    int elementComparison = x[i].CompareTo(y[i]);
                    if (elementComparison != 0)
                    {
                        return elementComparison;
                    }
                }
            }

            return lengthComparison;
        }
    }
}
