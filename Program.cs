using data_structures.Array;
using data_structures.LinkedList;
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
            var list = new List<int>() { 1,2,3,4,5};
            var linkedList = new SinglyLinkedList<int>(list);

            linkedList.Remove(1);
            foreach (var item in linkedList)
            {
                Console.Write($"{item,-4}");
            }
            Console.WriteLine();
            linkedList.Remove(5);
            foreach (var item in linkedList)
            {
                Console.Write($"{item,-3}");
            }

            linkedList.Remove(3);
            Console.WriteLine();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.Remove(2);
            linkedList.Remove(4);
            Console.WriteLine(linkedList.Count());
        }
    }
}
