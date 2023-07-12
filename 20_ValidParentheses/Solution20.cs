using _0_Xtra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ValidParentheses
{
    public class Solution20 
    {
        public static void SolutionValidParentheses()
        {
            Solution solution = new Solution();

            bool result = solution.IsValid("()[]{}");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '{' || c == '(' || c == '[')
                {
                    stack.Push(c);
                }

                if (c == '}' || c == ')' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char popped = stack.Pop();
                    
                    if (c == ')' && popped != '(' ||
                        c == ']' && popped != '[' ||
                        c == '}' && popped != '{')
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}