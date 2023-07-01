using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.Array
{
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList { get; set; }
        public int Count { get; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }

        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                InnerList[Count] = item;
                Count++;
            }
        }

        public Array(IEnumerable<T> collection)
        {
            InnerList = new T[collection.ToArray().Length];
            Count = 0;
            foreach (T item in collection)
            {
                InnerList[Count] = item;
                Count++;
            }
        }

        public void Add(T item)
        {
            if (Count == InnerList.Length)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }
        public void AddRange(params T[] range)
        {
            foreach (var item in range)
            {
                if (Count == InnerList.Length)
                    DoubleArray();
                InnerList[Count] = item;
                Count++;
            }
        }

        public void AddAfter(T after,T item)
        {
            for(int i = 0; i < Count; i++)
            {
                if (InnerList[i].Equals(after))
                {
                    if (Count == InnerList.Length)
                        DoubleArray();
                    for(int k = Count-1;k > i; k--)
                    {
                        InnerList[k + 1] = InnerList[k];
                    }
                    InnerList[i + 1] = item;
                    Count++;
                    return;
                }
            }
            throw new Exception("There is not this item in the array");
        }
        public void AddBefore(T before,T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (InnerList[i].Equals(before))
                {
                    if (Count == InnerList.Length)
                        DoubleArray();
                    for (int k = Count - 1; k > i-1; k--)
                    {
                        InnerList[k + 1] = InnerList[k];
                    }
                    InnerList[i] = item;
                    Count++;
                    return;
                }
            }
            throw new Exception("There is not this item in the array");
        }
        public T GetValue(int index)
        {
            if (Count == 0)
                throw new Exception("This array is empty");
            if (index > Count)
                throw new Exception("Array Index Out Of Bounds");
            return InnerList[index];
        }
        public void SetValue(int set,T value,bool withIndex)
        {
            if(withIndex)
            {
                if (Count == 0)
                    throw new Exception("This array is empty");
                if (set > Count)
                    throw new Exception("Array Index Out Of Bounds");
                InnerList[set] = value;
            }
            else
            {
                if (Count == 0)
                    throw new Exception("This array is empty");
                for (int i = 0; i < Count; i++)
                {
                    if (InnerList[i].Equals(set))
                    {
                        InnerList[i] = value;
                        return;
                    }
                }
                throw new Exception("There is not this item in the array");
            }
        }
        public T Remove()
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from the array");
            if (Count == InnerList.Length / 4)
                HalfArray();
            var temp = InnerList[Count-1];
            Count--;
            return temp;
        }
        public T Remove(T element)
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from the array");
            for(int i = 0; i < Count; i++)
            {
                if (InnerList[i].Equals(element))
                {
                    for(int k =i; k < Count-1; k++)
                    {
                        InnerList[k] = InnerList[k + 1];
                    }
                    if (Count == InnerList.Length / 4)
                        HalfArray();
                    Count--;
                    return element;
                }
            }
            throw new Exception("There is not this item in the array");
        }

        private void HalfArray()
        {
            var temp = new T[InnerList.Length/2];
            System.Array.Copy(InnerList, temp, InnerList.Length/2);
            InnerList = temp;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length*2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            var arr = new Array<T>();
            foreach (var item in this)
            {
                arr.Add(item);
            }
            return arr;
        }
    }
}
