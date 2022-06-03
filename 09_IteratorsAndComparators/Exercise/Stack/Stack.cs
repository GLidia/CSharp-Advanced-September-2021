using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T> : IEnumerable<T>
    {
        public List<T> Elements { get; private set; }

        public Stack(params T[] elements)
        {
            this.Elements = new List<T>(elements);
        }

        public void Push(T element)
        {
            this.Elements.Add(element);
        }

        public T Pop()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            else
            {
                T element = this.Elements[this.Elements.Count - 1];
                this.Elements.RemoveAt(this.Elements.Count - 1);
                return element;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Elements.Count - 1; i >= 0; i--)
            {
                yield return this.Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
