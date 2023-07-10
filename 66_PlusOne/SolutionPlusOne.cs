using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_PlusOne
{
    public class SolutionPlusOne
    {
        public static void Solution66()
        {
            Solution solution = new Solution();

            int[] result = solution.PlusOne(new int[] { 9, 9 });
            Helper.WriteLine(result);
        }
    }

    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            Array.Reverse(digits);

            for (int i = 0; i < digits.Length; i++)
            {
                if ((digits[i] + 1) == 10)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    break;
                }
            }

            digits = (digits[digits.Length - 1] == 0) ? PlusDigit(digits, 1) : digits;
            Array.Reverse(digits);
            return digits;
        }

        public int[] PlusDigit(int[] liste, int digitAdd)
        {
            int[] listeNew = new int[liste.Length + 1];
            Array.Copy(liste, listeNew, liste.Length);
            listeNew[listeNew.Length - 1] = digitAdd;
            return listeNew;
        }

        public int[] PlusOneTotal(int[] digits)
        {
            Array.Reverse(digits);
            long total = 0;
            long x = 1;

            foreach (long i in digits)
            {
                total += i * x;
                x *= 10;
            }

            List<int> listeInt = new List<int>();
            string digitsString = (total + 1).ToString();

            foreach (char c in digitsString)
            {
                int digit = int.Parse(c.ToString());
                listeInt.Add(digit);
            }

            int[] listeIntArray = listeInt.ToArray();
            return listeIntArray;
        }
    }
}
