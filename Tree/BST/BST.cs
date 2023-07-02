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
        public Node<T> FindMin(Node<T> root)
        {
            var currentNode = root;
            while(currentNode.Left != null)
                currentNode = currentNode.Left;
            return currentNode;   
        }
        public Node<T> FindMax(Node<T> root)
        {
            var currentNode = root;
            while (currentNode.Right != null)
                currentNode = currentNode.Right;
            return currentNode;
        }
        public Node<T> Find(Node<T> root, T value)
        {
            var currentNode = root;
            if (currentNode == null)
                throw new ArgumentNullException("NULL");
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                {
                    return currentNode;
                }
                else if (currentNode.Value.CompareTo(value) > 0)
                    currentNode = currentNode.Left;
                else
                    currentNode = currentNode.Right;
            }
            throw new Exception("Bulunamadı");
        }
        public Node<T> Remove(Node<T> root,T key)
        {
            if (root == null)
                return root;

            if (key.CompareTo(root.Value) < 0)
                root.Left = Remove(root.Left, key);
            else if (key.CompareTo(root.Value) > 0)
                root.Right = Remove(root.Right, key);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Value = FindMin(root.Right).Value;

                root.Right = Remove(root.Right, root.Value);
            }

            return root;
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
