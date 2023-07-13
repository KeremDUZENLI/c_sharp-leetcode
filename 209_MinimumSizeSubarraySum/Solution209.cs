using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209_MinimumSizeSubarraySum
{
    public class Solution209 
    {
        public static void MinimumSizeSubarraySum()
        {
            Solution solution = new Solution();
            int result = solution.MinSubArrayLen(214, new List<int> { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 });
            Console.WriteLine(result);
        }

        public static void MinimumSizeSubarraySum_2()
        {
            Solution solution = new Solution();

            List<int> listeSub = new List<int>();
            List<List<int>> listeNew = new List<List<int>>();
            solution.ListCreate(new List<int> { 1, 2, 3, 4, 5 }, listeSub, 0, 5, listeNew);
            listeNew.Sort(new ListCountComparer());

            foreach (List<int> x in listeNew)
            {
                Solution0.WriteLine(x);
            }
        }
    }

    public class Solution
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
                    Solution0.WriteLine(x);
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
