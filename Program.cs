using data_structures.Array;
using data_structures.LinkedList;
using data_structures.LinkedList.DoublyLinkedList;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            foreach (var item in list)
            {
                Console.Write($"{item,-3}");
            }

            list.AddAfter(1, -1);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item,-3}");
            }
            list.AddAfter(3, -1);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item,-3}");
            }
            list.AddAfter(2, -2);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item,-3}");
            }
            list.AddAfter(-1, -10);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
