using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace data_structures.LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        public DoublyLinkedList()
        {
            
        }
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
                AddLast(item);
        }

        public void AddFirst(T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                return;
            }
            newNode.Next = Head;
            Head.Prev = newNode;
            Head = newNode;
        }
        public void AddLast(T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);
            if (Head == null)
            {
                AddFirst(item);
                return;
            }
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }

        public void AddAfter(T refNode,T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);
            if (Head == null)
            {
                AddFirst(item);
                return;
            }
            var current = Head;
            
            while(current != null)
            {
                if(current.Value.Equals(refNode))
                {
                    if(current.Next == null)
                    {
                        AddLast(item); return;
                    }
                    newNode.Next = current.Next;
                    current.Next.Prev = newNode;
                    current.Next = newNode;
                    newNode.Prev = current;
                }
                current = current.Next;
            }
        }
        public void AddBefore(T refNode,T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);
            if (Head == null)
            {
                AddFirst(item);
                return;
            }
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(refNode))
                {
                    if (current.Prev == null)
                    {
                        AddFirst(item);
                        return;
                    }
                    newNode.Prev = current.Prev;
                    newNode.Next = current;
                    current.Prev.Next = newNode;
                    current.Prev = newNode;
                }
                current = current.Next;
            }
        }
        public T RemoveFirst()
        {
            if (Head == null)
                throw new Exception("LinkedList is empty");
            var value = Head.Value;
            if (Head==Tail)
            {
                Head = null;
                Tail = null;
                return value;
            }
            Head = Head.Next;
            Head.Prev = null;
            return value;
        }
        public T RemoveLast()
        {
            if (Head == null)
                throw new Exception("LinkedList is empty");
            var value = Tail.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                return value;
            }
            Tail = Tail.Prev;
            Tail.Next = null;
            return value;
        }
        public void Remove(T item)
        {
            if(Head.Value.Equals(item))
                RemoveFirst();
            else if(Tail.Value.Equals(item))            
                RemoveLast();
            else
            {
                var current = Head;
                while(current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                        return;
                    }
                    current = current.Next;
                }
                throw new Exception("There is not this item in the linked list"); 
            }
        }
        public int Count()
        {
            int count = 0;
            var current = Head;
            while (current != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
