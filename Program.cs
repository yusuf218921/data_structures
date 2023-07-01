using System;
using data_structures.Stack;

namespace data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "231*+9-";
            Console.WriteLine(PostFixExample.Run(str));
        }
    }
}
