using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RomanToInteger
{
    public class Solution13
    {
        public static void RomanToInteger()
        {
            Solution solution = new Solution();

            int result = solution.RomanToInt("MCMXCIV");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            int total = 0;

            Dictionary<char, int> listeRoman = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            for (int i = 0; i < s.Length; i++)
            {
                int valueCurrent = listeRoman[s[i]];

                if (i + 1 < s.Length)
                {
                    int valueNext = listeRoman[s[i + 1]];

                    if (valueCurrent < valueNext)
                    {
                        total -= valueCurrent;
                    }
                    else
                    {
                        total += valueCurrent;
                    }
                }
                else
                {
                    total += valueCurrent;
                }
            }

            return total;
        }
    }
}
