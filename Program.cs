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
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            var linkedlist = new DoublyLinkedList<int>(list);
            linkedlist.Remove(3);
            foreach (var item in linkedlist)
            {
                Console.Write($"{item,-4}");
            }
            Console.WriteLine();
            linkedlist.Remove(1);
            foreach (var item in linkedlist)
            {
                Console.Write($"{item,-4}");
            }
            Console.WriteLine();
            linkedlist.Remove(5);
            foreach (var item in linkedlist)
            {
                Console.Write($"{item,-4}");
            }
            Console.WriteLine();
            linkedlist.Remove(4);
            foreach (var item in linkedlist)
            {
                Console.Write($"{item,-4}");
            }
            Console.WriteLine();
            linkedlist.Remove(2);
            Console.WriteLine(linkedlist.Count());

            Console.ReadKey();
        }
    }
}
