using System;
using System.Linq;
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
            BinaryTree<int> bt = new BinaryTree<int>();
            var tree = new BST<int>(23,16,45,3,22,37);
            Console.WriteLine($"Number of Leap : {bt.LeapCount(tree.Root)}");
            Console.WriteLine($"Number of FullNode : {bt.FullNodeCount(tree.Root)}");
            Console.WriteLine($"Number of HaflNode : {bt.HalfNodeCount(tree.Root)}");
            Console.WriteLine(bt.isFullTree(tree.Root));
        }
    }
}
