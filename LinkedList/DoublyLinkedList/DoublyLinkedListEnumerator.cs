using System.Collections;
using System.Collections.Generic;

namespace data_structures.LinkedList.DoublyLinkedList
{
    internal class DoublyLinkedListEnumerator<T> : IEnumerator<T>
    {

        private DoublyLinkedListNode<T> Head;
        private DoublyLinkedListNode<T> _current;
        public DoublyLinkedListEnumerator(DoublyLinkedListNode<T> head)
        {
            Head = head;
            _current = null;
        }
        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}