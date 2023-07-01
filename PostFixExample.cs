using data_structures.Stack;
using System;
using System.Text;

namespace data_structures
{
    public class PostFixExample
    {
        private string expression;
        Stack<string> stack = new Stack<string> (StackType.LinkedList);
        private string Expression()
        {
            int val1, val2, ans;
            for(int i = 0; i < expression.Length; i++)
            {
                String c = expression.Substring(i,1);
                if(c == "+")
                {
                    val1 = int.Parse(stack.Pop());
                    val2 = int.Parse(stack.Pop());
                    ans = val2 + val1;
                    stack.Push(ans.ToString());
                }
                else if(c == "-")
                {
                    val1 = int.Parse(stack.Pop());
                    val2 = int.Parse(stack.Pop());
                    ans = val2 - val1;
                    stack.Push(ans.ToString());
                }
                else if (c == "*")
                {
                    val1 = int.Parse(stack.Pop());
                    val2 = int.Parse(stack.Pop());
                    ans = val2 * val1;
                    stack.Push(ans.ToString());
                }
                else if( c == "/")
                {
                    val1 = int.Parse(stack.Pop());
                    val2 = int.Parse(stack.Pop());
                    ans = val2 / val1;
                    stack.Push(ans.ToString());
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Pop();
        }
        public static string Run(string expression)
        {
            PostFixExample e = new PostFixExample();
            e.expression = expression;
            return e.Expression();
        }
    }
}
