using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_AddBinary
{
    public class Solution67 
    {
        public static void AddBinary()
        {
            Solution solution = new Solution();

            string result = solution.AddBinary("10101", "101");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            List<char> listeA = new List<char>(a.ToCharArray());
            listeA.Reverse();

            List<char> listeB = new List<char>(b.ToCharArray());
            listeB.Reverse();

            List<int> listeNew = new List<int>();
            int articule = 0;

            if (listeA.Count > listeB.Count)
            {
                int i = listeA.Count - listeB.Count;
                while (i > 0)
                {
                    listeB.Add('0');
                    i--;
                }
            }
            else
            {
                int i = listeB.Count - listeA.Count;
                while (i > 0)
                {
                    listeA.Add('0');
                    i--;
                }
            }

            for (int i = 0; i < listeB.Count; i++)
            {
                if (((listeA[i] | listeB[i]) == '1') & ((listeA[i] & listeB[i]) != '1'))
                {
                    if (articule == 1)
                    {
                        listeNew.Add(0);
                        articule = 1;
                    }
                    else
                    {
                        listeNew.Add(1);
                        articule = 0;
                    }
                }
                else if ((listeA[i] & listeB[i]) == '0')
                {
                    if (articule == 1)
                    {
                        listeNew.Add(1);
                        articule = 0;
                    }
                    else
                    {
                        listeNew.Add(0);
                        articule = 0;
                    }
                }
                else
                {
                    if (articule == 1)
                    {
                        listeNew.Add(1);
                        articule = 1;
                    }
                    else
                    {
                        listeNew.Add(0);
                        articule = 1;
                    }
                }
            }

            listeNew.Reverse();

            if (articule == 1)
            {
                listeNew.InsertRange(0, new int[] { 1 });
            }

            string result = string.Join("", listeNew);
            return result;
        }
    }
}
