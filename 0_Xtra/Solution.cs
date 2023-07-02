using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Xtra
{
    public static class Solution
    {
        public static void WriteLine(List<Action> functionsList)
        {
            foreach (Action function in functionsList)
            {
                Console.WriteLine($"\n{function.Method.Name}:");
                function();
            }
        }

        public static void WriteLineList<T>(IEnumerable<T> liste)
        {
            string result = "[" + string.Join(", ", liste) + "]";

            Console.WriteLine(result);
        }
    }
}
