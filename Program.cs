using System;
using System.Runtime.InteropServices;
using data_structures.Queue;
using data_structures.Tree.BinaryTree;
using data_structures.Tree.BST;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tree = new BST<int>(23,16,45,2,36,99);
            var bt = new BinaryTree<int>();
            tree.Remove(tree.Root,23);
            bt.LevelOrderNonRecursiveTraversal(tree.Root).ForEach(x => Console.WriteLine(x));   
        }
    }
}
