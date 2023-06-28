using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PalindromeNumber
{
    public class SolutionPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0){ return false; }

            int number = x;
            int digitCount = 0;
            List<int> liste = new List<int> ();
            bool res = true;

            if (number == 0)
            {
                digitCount++;
            }
            else
            {
                while (number != 0)
                {
                    number /= 10;
                    digitCount++;
                }
            }

            for (int n = 0; n < digitCount; n++)
            {
                int a = x % (int)Math.Pow(10, n+1);
                x -= a;

                a /= (int)Math.Pow(10, n);
                liste.Add(a);
            }

            for (int l = 0; l < digitCount / 2; l++)
            {
                if (liste[l] != liste[digitCount - l - 1])
                {
                    res = false;
                }
            }

            return res;
        }
    }
}
