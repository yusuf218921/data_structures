using System;
using data_structures.Queue;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3 };
            var q1 = new Queue<int>();
            var q2 = new Queue<int>(QueueType.LinkedList);
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                q1.EnQueue(number);
                q2.EnQueue(number);
            }

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q1 Count : {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q2");

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q1 Count : {q2.Count}");

            Console.WriteLine($"q1 Peek : {q1.Peek()}");
            Console.WriteLine($"q1 Peek : {q2.Peek()}");



            Console.ReadKey();
        }
    }
}
