using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209_MinimumSizeSubarraySum
{
    public class SolutionMinimumSizeSubarraySum
    {
        public int MinSubArrayLen(int target, List<int> nums)
        {
            List<int> subListe = new List<int>();
            List<List<int>> newListe = new List<List<int>>();

            ListCreate(nums, subListe, 0, nums.Count, newListe);
            newListe.Sort(new ListCountComparer());

            foreach (List<int> x in newListe)
            {
                if (Total(x) > target)
                {
                    Solution.WriteLine(x);
                    Console.WriteLine("{0} Total --- {1} Target", Total(x), target);
                    return x.Count;
                } 
            }

            return 0;
        }

        public void ListCreate(List<int> liste, List<int> subListe, int indexStart, int desire, List<List<int>> newListe)
        {
            for (int i = indexStart; i < liste.Count; i++)
            {
                subListe.Add(liste[i]);

                if (desire > 1)
                {
                    ListCreate(liste, subListe, i + 1, desire - 1, newListe);
                }

                newListe.Add(new List<int>(subListe));
                //Solution.WriteLineList(subListe);
                subListe.Remove(liste[i]);
            }
        }

        public int Total(List<int> subListe)
        {
            int total = 0;

            foreach (int num in subListe)
            {
                total += num;
            }

            return total;
        }
    }
}
