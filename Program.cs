using System;
using data_structures.Queue;
using data_structures.Tree.BST;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new BST<int>(23,16,45,3,22,37,39);
            
            tree.PreOrder(tree.Root);
            Console.WriteLine(new string('-',50));
            tree.InOrder(tree.Root);
            Console.WriteLine(new string('-', 50));
            tree.PostOrder(tree.Root);
            Console.ReadKey();
        }
    }
}
