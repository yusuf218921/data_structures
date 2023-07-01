namespace data_structures.Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;
        public Queue(QueueType type = QueueType.Array)
        {
            if(type == QueueType.Array)
            {
                queue = new ArrayQueue<T>();
            }
            else
            {
                queue = new LinkedListQueue<T>();
            }
        }
        public void EnQueue(T item)
        {
            queue.EnQueue(item);
        }
        public T DeQueue()
        {
            return queue.DeQueue();
        }
        public T Peek()
        {
            return queue.Peek();
        }
        public void Clear()
        {
            queue.Clear();
        }
    }
    public enum QueueType
    {
        Array = 0,
        LinkedList = 1
    }
    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T item);
        T DeQueue();
        T Peek();
        void Clear();
    }
}
