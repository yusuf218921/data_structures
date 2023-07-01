using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.Tree.BST
{
    public class BST<T> : IEnumerable<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {
            Root = null;
        }
        public BST(params T[] values)
        {
            foreach (var item in values)
            {
                Add(item);
            }
        }
        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if(value == null)
                throw new ArgumentNullException("NULL");
            if(Root == null)
            {
                Root = newNode;
                return;
            }
            var current = Root;
            while(true)
            {
                // sağ-alt ağaç
                if (newNode.Value.CompareTo(current.Value)>0)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        return;
                    }
                    current = current.Right;
                }
                // sol-alt ağaç
                else
                {
                    if(current.Left == null)
                    {
                        current.Left = newNode;
                        return;
                    }   
                    current = current.Left;
                }
            }
            
        }
        public void PreOrder(Node<T> node)
        {
            if (node == null)
                return;
            Console.WriteLine($"{node.Value,-3} - ");
            PreOrder(node.Left);
            PreOrder(node.Right);

        }
        public void InOrder(Node<T> node)
        {
            if (node == null)
                return;
            InOrder(node.Left);
            Console.WriteLine($"{node.Value,-3} - ");
            InOrder(node.Right);

        }
        public void PostOrder(Node<T> node)
        {
            if (node == null)
                return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.WriteLine($"{node.Value,-3} - ");
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
