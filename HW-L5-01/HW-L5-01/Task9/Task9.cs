using System.Collections.Generic;

namespace Practice.Task9
{
    public class Parentheses
    {
        public static bool IsValid(string text)
        {
            Stack<char> stack = new Stack<char>();


            foreach (char ch in text)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if (ch == ')' && top != '(')
                        return false;

                    if (ch == ']' && top != '[')
                        return false;

                    if (ch == '}' && top != '{')
                        return false;
                }
            }


            return stack.Count == 0;
        }
    }
}