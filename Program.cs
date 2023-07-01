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
            char[] arr = new char[] { 'A', 'B', 'C' };
            var linkedList = new SinglyLinkedList<char>(arr);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
