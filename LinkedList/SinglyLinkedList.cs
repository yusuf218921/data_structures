﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.LinkedList
{
    internal class SinglyLinkedList<T> : IEnumerable<T>
    {
        SinglyLinkedListNode<T> Head;

        public SinglyLinkedList()
        {
            Head = null;
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
        public void AddBefore(T value, T item)
        {
            var newNode = new SinglyLinkedListNode<T>(item);

            if (Head == null)
            {
                Head = newNode;
                return;
            }
            var temp = new SinglyLinkedListNode<T>();
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    newNode.Next = current;
                    temp.Next = newNode;
                    return;
                }
                temp = current;
                current = current.Next;
            }
            throw new Exception("There is not this item in the linked list");
        }

        public void AddAfter(T value, T item)
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
                if (current.Value.Equals(value))
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

        public T Remove(T item)
        {
            var temp = new SinglyLinkedListNode<T>();
            var current = Head;
            while (current != null)
            {
                if(current.Value.Equals(item))
                {
                    temp.Next = current.Next;
                    return current.Value;
                }
                temp = current;
                current = current.Next;
            }
            throw new Exception("There is not this item in the linked list");
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
