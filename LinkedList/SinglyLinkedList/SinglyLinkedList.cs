using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.LinkedList
{
    public class SinglyLinkedListQueue<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head;

        public SinglyLinkedListQueue()
        {
            Head = null;
        }

        public SinglyLinkedListQueue(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                this.AddLast(item);
        }

        public void AddFirst(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            if(Head == null)
            {
                Head = newNode;
                return;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var current = Head;
            while(current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public void AddBefore(T before, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            SinglyLinkedListNode<T> prev = null;
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(before))
                {
                    if (prev == null)
                    {
                        AddFirst(item);
                        return;
                    }
                    else
                    {
                        newNode.Next = current;
                        prev.Next = newNode;
                        return;
                    }
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("There is not this item in the linked list");
        }

        public void AddAfter(T after, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(after))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new Exception("There is not this item in the linked list");
        }

        public int Count()
        {
            int count = 0;
            var current = Head;
            while(current != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public void Remove(T item)
        {
            SinglyLinkedListNode<T> prev = null;
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if(prev == null)
                    {
                        RemoveFirst();
                        return;
                    }
                    if (current.Next == null)
                    {
                        RemoveLast();
                        return;
                    }
                    prev.Next = current.Next;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("There is not this item in the linked list");
        }
        public T RemoveFirst()
        {
            var value = Head.Value;
            var current = Head.Next;
            Head = current;
            return value;
        }
        public T RemoveLast()
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while(current.Next != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = null;
            return current.Value;
            
        }
        public void Clear()
        {
            Head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
