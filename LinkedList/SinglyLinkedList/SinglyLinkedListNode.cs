using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.LinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next;
        public T Value;
        public SinglyLinkedListNode()
        {
            
        }
        public SinglyLinkedListNode(T _value)
        {
            Value = _value;
        }
    }
}
