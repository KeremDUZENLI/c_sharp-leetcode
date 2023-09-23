using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Sqrt_x_
{
    public class Solution69 
    {
        public static void Sqrt()
        {
            Solution solution = new Solution();

            int result = solution.MySqrt(99);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MySqrt(int x)
        {
            double root = Math.Sqrt(Convert.ToDouble(x));

            return Convert.ToInt32(Math.Floor(root));
        }
    }
}
