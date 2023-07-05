using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_FindTheIndexOfTheFirstOccurrenceInAString
{
    public class SolutionFindTheIndexOfTheFirstOccurrenceInAString
    {
        public List<char> StrStr(string haystack, string needle)
        {
            List<char> liste = new List<char>();

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool match = true;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        for (int k = 0; k < needle.Length; k++)
                        {
                            liste.Add(haystack[i + k]);
                        }
                        return liste;
                    }
                }
            }

            return liste;
        }
    }
}
