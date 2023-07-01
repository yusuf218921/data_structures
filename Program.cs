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
            var linkedList = new SinglyLinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(5);
            linkedList.AddAfter(3, 4);
            Console.WriteLine(linkedList.Count());
            linkedList.AddAfter(5, 6);
            Console.WriteLine(linkedList.Count());
            linkedList.Remove(3);
            Console.WriteLine(linkedList.Count());
            Console.ReadKey();
        }
    }
}
