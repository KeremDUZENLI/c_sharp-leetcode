using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_ClimbingStairs
{
    public class Solution70 
    {
        public static void ClimbingStairs()
        {
            Solution solution = new Solution();

            int result = solution.ClimbStairs(5);
            Console.WriteLine(result);
        }

        public static void ClimbingStairs_2()
        {
            Solution_2 solution_2 = new Solution_2();

            int result = solution_2.ClimbStairs(5);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int ClimbStairs(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return VarietyDict(n, dict);
        }

        public int VarietyDict(int n, Dictionary<int, int> dict)
        {
            if (n <= 2)
            {
                return n;
            }

            if (dict.ContainsKey(n))
            {
                return dict[n];
            }

            int total = VarietyDict(n - 1, dict) + VarietyDict(n - 2, dict);
            dict[n] = total;

            return total;
        }
    }

    public class Solution_2
    {
        public int ClimbStairs(int n)
        {
            List<int> liste = new List<int>();
            List<List<int>> listeTotal = new List<List<int>>();

            GenerateStepCombinationsRecursive(n, liste, listeTotal);
            return listeTotal.Count;
        }

        public void GenerateStepCombinationsRecursive(int remainingSteps, List<int> currentCombination, List<List<int>> totalCombination)
        {
            if (remainingSteps == 0)
            {
                //Helper.WriteLine(currentCombination);
                totalCombination.Add(currentCombination);
                return;
            }

            if (remainingSteps >= 1)
            {
                List<int> combinationWith1Step = new List<int>(currentCombination);
                combinationWith1Step.Add(1);
                GenerateStepCombinationsRecursive(remainingSteps - 1, combinationWith1Step, totalCombination);
            }

            if (remainingSteps >= 2)
            {
                List<int> combinationWith2Steps = new List<int>(currentCombination);
                combinationWith2Steps.Add(2);
                GenerateStepCombinationsRecursive(remainingSteps - 2, combinationWith2Steps, totalCombination);
            }
        }
    }
}
