using data_structures.Array;
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
            Array<int> arr = new Array<int>(32,2,3,4,5,6);
            arr.SetValue(2,3333,true);
        }
    }
}
