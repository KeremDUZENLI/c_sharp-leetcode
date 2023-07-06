using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_LengthOfLastWord
{
    public class SolutionLengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            string[] liste = s.Trim().Split();

            return (liste.Length == 0) ? 0 : liste[liste.Length - 1].Length;
            //return s.Trim().Split(' ').Last().Length;
        }
    }
}
