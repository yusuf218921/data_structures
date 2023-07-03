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
        public Node<T> Root = new Node<T>();

        public BinaryTree(Node<T> root)
        {
            Root = root;
        }
        public BinaryTree(T value)
        {
            Root.Value = value;
            Root.Right = null;
            Root.Left = null;
        }

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
        public static int MaxDepth(Node<T> root)
        {
            if(root== null)
                return 0;
            int leftDepth = MaxDepth(root.Left);
            int rightDepth = MaxDepth(root.Right);

            return (leftDepth > rightDepth) ? leftDepth+1 : rightDepth+1;
        }
        public Node<T> DeepestNode(Node<T> root)
        {
            Node<T> temp = null;
            if (root == null)
                throw new Exception("null");

            var q = new Queue.Queue<Node<T>>();

            q.EnQueue(root);
            while(q.Count > 0)
            {
                temp = q.DeQueue();
                if (temp.Left != null)
                    q.EnQueue(temp.Left);
                if(temp.Right != null)
                    q.EnQueue(temp.Right);
            }
            return temp;
        }
        public Node<T> DeepestNode()
        {
            var list = LevelOrderNonRecursiveTraversal(Root);
            return list[list.Count - 1];
        }
        public int LeapCount(Node<T> root)
        {
            int count = 0;
            if (root == null)
                return count;
            var q = new Queue.Queue<Node<T>>();
            q.EnQueue(root);
            while (q.Count > 0)
            {
                var temp = q.DeQueue();
                if(temp.Left == null && temp.Right == null)
                    count++;
                if (temp.Left != null)
                    q.EnQueue(temp.Left);
                if (temp.Right != null)
                    q.EnQueue(temp.Right);
            }
            return count;
        }
        public int LeapCountWithList(Node<T> root)
        {
            return new BinaryTree<T>().InOrder(root).Where(x => x.Left == null && x.Right == null).ToList().Count;
        }
        public bool isFullTree(Node<T> root)
        {
            return new BinaryTree<T>().InOrder(root).Where(x => (x.Left == null && x.Right == null) || (x.Left != null && x.Right != null)).ToList().Count== new BinaryTree<T>().InOrder(root).Count;
        }
        public int HalfNodeCount(Node<T> root)
        {
            return new BinaryTree<T>().InOrder(root)
                .Where(x => (x.Right == null && x.Left!=null) ||
                (x.Right != null && x.Left == null)).ToList().Count;
        }
        public int FullNodeCount(Node<T> root)
        {
            return new BinaryTree<T>().InOrder(root)
                .Where(x => x.Right != null && x.Left != null).ToList().Count;
        }


        public void ListClear() => List.Clear();
    }
}
