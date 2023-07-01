using data_structures.LinkedList.DoublyLinkedList;

namespace data_structures.Queue
{
    internal class LinkedListQueue<T> : IQueue<T>
    {
        public int Count { get; private set; }
        private readonly DoublyLinkedList<T> linkedList = new DoublyLinkedList<T>();

        public void Clear()
        {
            linkedList.Clear();
        }

        public T DeQueue()
        {
            if (Count == 0)
                throw new System.Exception("EMPTY");
            var temp = linkedList.RemoveFirst();
            Count--;
            return temp;
        }

        public void EnQueue(T item)
        {
            if (item == null)
                throw new System.Exception("NULL");
            linkedList.AddLast(item);
            Count++;
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }
    }
}