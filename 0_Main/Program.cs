using _1_TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] liste = solution.TwoSum(new int[] { 3, 2, 4 }, 6);
            string result = "[" + string.Join(", ", liste) + "]";
            Console.WriteLine(result);



            Console.ReadLine();
        }
    }
}
