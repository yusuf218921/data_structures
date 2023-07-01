using System.Collections.Generic;
using System.Data;

namespace data_structures.Queue
{
    internal class ArrayQueue<T> : IQueue<T>
    {
        public int Count { get; private set; }
        private readonly List<T> list = new List<T>();

        public void Clear()
        {
            list.Clear();
        }

        public T DeQueue()
        {
            if (list.Count == 0)
                throw new System.Exception("queue is empty");
            var temp = list[0];
            list.RemoveAt(0);
            Count--;
            return temp;
        }

        public void EnQueue(T item)
        {
            if (item == null)
                throw new System.ArgumentNullException("NULL");
            list.Add(item);
            Count++;
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new System.Exception("queue is empty");
            return list[0];
        }
    }
}