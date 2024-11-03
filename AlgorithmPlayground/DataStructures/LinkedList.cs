using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.DataStructures
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node(T startData)
        {
            this.Data = startData;
            this.Next = null;
        }
    }

    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }

        public LinkedList(T firstData)
        {
            this.Head = new Node<T>(firstData);
        }

        public LinkedList()
        {
            this.Head = null;
        }

        public bool Any()
        {
            return this.Head != null;
        }

        /// <summary>
        /// /Adds a new node at the head of the List
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Add(T data)
        {
            var newNode = new Node<T>(data) {Next = this.Head};
            Head = newNode;

            return true;
        }

        public int Count()
        {
            var current = this.Head;
            var count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public bool Insert(T dataToInsert, int position)
        {
            if (position < 0)
                throw new IndexOutOfRangeException(
                    "Cannot insert a node at a negative position");

            if (position == 0)
            {
                return this.Add(dataToInsert);
            }

            var previous = this.Head;

            for (var i = 0; i < position - 1; i++)
            {
                if (previous == null)
                {
                    throw new IndexOutOfRangeException(
                        "Cannot insert a node at a position out of bounds of the list");
                }

                previous = previous.Next;
            }

            var newNode = new Node<T>(dataToInsert) {Next = previous.Next};
            previous.Next = newNode;

            return true;
        }

        public bool RemoveLastElement()
        {
            Node<T> previousNode = null;
            Node<T> current = Head;

            while (current.Next != null)
            {
                previousNode = current;
                current = current.Next;
            }

            if (previousNode?.Next != null)
            {
                previousNode.Next = null;
                return true;
            }

            return false;
        }

        public Node<T> Search(T targetValue)
        {
            var current = this.Head;

            while (current != null)
            {
                if (current.Data.Equals(targetValue))
                    return current;

                current = current.Next;
            }

            return null;
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

    public static class LinkedListExtensions
    {
    }
}
