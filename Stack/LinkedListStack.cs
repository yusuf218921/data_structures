using data_structures.LinkedList;
using System;

namespace data_structures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        public int Count { get; private set; }
        private readonly SinglyLinkedListQueue<T> linkedList = new SinglyLinkedListQueue<T> ();

        public void Clear()
        {
            linkedList.Clear();
        }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("stack is empty");
           return linkedList.Head.Value;
        }

        public T Pop()
        {
            if (linkedList.Count() == 0)
                throw new Exception("Stack is empty");
            var temp = linkedList.Head.Value;
            linkedList.RemoveFirst();
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            if(value == null)
                throw new ArgumentNullException("NUll");
            linkedList.AddFirst(value);
            Count++;
        }
    }
}