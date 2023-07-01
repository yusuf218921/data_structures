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
            foreach (var item in linkedList)
            {
                Console.Write($"{item,-3}");
            }

            Console.WriteLine();
            linkedList.RemoveFirst();
            foreach (var item in linkedList)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine();
            linkedList.RemoveLast();
            foreach (var item in linkedList)
            {
                Console.Write($"{item,-3}");
            }
        }
    }
}
