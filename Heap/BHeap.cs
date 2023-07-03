using data_structures.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.Heap
{
    public class BHeap<T>
        where T : IComparable
    {
        public Array<T> Array { get; private set; }
        private int position;
        public int Count { get; private set; }
        public BHeap()
        {
            Count = 0;
            Array = new Array<T> { };
            position = 0;
        }

        // Parent = (i-1)/2
        // L = 2i+1
        // R = 2i+2
        private int GetLeftChildIndex(int i) => 2 * i + 1;
        private int GetRightChildIndex(int i) => 2 * i + 2;
        private int GetParentsIndex(int i) => (i - 1) / 2;
        private bool HasLeftChild(int i) => 
            GetLeftChildIndex(i) < position;
        private bool HasRightChild(int i) =>
            GetLeftChildIndex(i) < position;
        private bool IsRoot(int i) =>
            i == 0;
        private T GetLeftChild(int i) => Array.GetValue(GetLeftChildIndex(i));
        private T GetRightChild(int i) => Array.GetValue(GetRightChildIndex(i));
        private T GetParent(int i) => Array.GetValue(GetParentsIndex(i));
        public bool IsEmpty() => position == 0;
        public T Peek()
        {
            if (IsEmpty())
                throw new Exception("Heap is empty");
            return Array.GetValue(0);
        }
        
        public void Swap(int first,int second)
        {
            var temp = Array.GetValue(first);
            Array.SetValue(first, Array.GetValue(second), true);
            Array.SetValue(second, temp, true);
        }
        public void Add(T item)
        {
            //To Do
        }
        
    }
}
