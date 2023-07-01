using System;
using data_structures.Stack;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charset = new char[] {  'a', 'b', 'c' };
            var stack1 = new Stack<char>();
            var stack2 = new Stack<char>(StackType.LinkedList);
            foreach (var item in charset)
            {
                stack1.Push(item); 
            }
            var stack1Count = stack1.Count;
            Console.WriteLine($"Stack eleman sayısı -> {stack1.Count}");
            for (int i = 0;i < stack1Count;i++)
            {
                Console.WriteLine(stack1.Pop());
            }
            Console.WriteLine();
            foreach (var item in charset)
            {
                stack2.Push(item);
            }
            var stack2Count = stack2.Count;
            for (int i = 0; i < stack2Count; i++)
            {
                Console.WriteLine(stack2.Pop());
            }
        }
    }
}
