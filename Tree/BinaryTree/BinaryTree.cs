using data_structures.Tree.BST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public List<Node<T>> List { get; private set; }
        public BinaryTree()
        {
            List = new List<Node<T>>();
        }
        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (!(root == null))
            {
                List.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return List;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            var stack = new Stack.Stack<Node<T>>();
            stack.Push(root);
            while (stack.Count!=0)
            {
                var currentNode = stack.Pop();
                list.Add(currentNode);
                if (currentNode.Right != null)
                    stack.Push(currentNode.Right);
                if (currentNode.Left != null)
                    stack.Push(currentNode.Left); 
            }
            return list;
        }
        
        public List<Node<T>> InOrder(Node<T> root)
        {
            if (!(root == null))
            {
                InOrder(root.Left);
                List.Add(root);
                InOrder(root.Right);
            }
            return List;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            var stack = new Stack.Stack<Node<T>>();
            var currentNode = root;
            bool done = false;
            while (!done)
            {
                if(currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = stack.Pop();
                        list.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }
            return list;
        }
        public List<Node<T>> PostOrder(Node<T> root)

        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                List.Add(root);
            }
            return List;
        }
        public List<Node<T>> PostOrderNonRecursiveTraversal(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            var stack = new Stack.Stack<Node<T>>();
            var currentNode = root;
            Node<T> lastVisitedNode = null;
            while (stack.Count !=0 || currentNode != null) 
            {
                if(currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    Node<T> peekNode = stack.Peek();
                    if (peekNode.Right != null && lastVisitedNode != peekNode.Right)
                    {
                        currentNode = peekNode.Right;
                    }
                    else
                    {
                        list.Add(peekNode);
                        lastVisitedNode = stack.Pop();
                    }
                }
            }
            return list;
        }
        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            var q = new Queue.Queue<Node<T>>();
            q.EnQueue(root);
            var currentNode = root;
            while (q.Count != 0)
            {
                currentNode = q.Peek();
                if (currentNode.Left != null)
                    q.EnQueue(currentNode.Left);
                if (currentNode.Right != null) 
                    q.EnQueue(currentNode.Right);
                list.Add(q.DeQueue());
            }
            return list;

        }
        
        public void ListClear() => List.Clear();
    }
}
