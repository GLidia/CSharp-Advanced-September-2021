using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        private class ListNode
        {
            public T Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            ListNode currentNode = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public void ForEach(Action<T> action)
        {
            ListNode currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            T toReturn = this.tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            Count--;
            return toReturn;

        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else if (this.Count == 1)
            {
                T toReturn = this.head.Value;
                this.head = this.tail = null;
                Count--;
                return toReturn;
            }
            else
            {
                T toReturn = this.head.Value;
                this.head = this.head.NextNode;
                this.head.PreviousNode = null;
                Count--;
                return toReturn;
            }
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            Count++;
        }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            Count++;
        }
    }
}
