using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        public List<T> Elements { get; private set; }

        private int currentIndex; 

        public ListyIterator(params T[]elements)
        {
            this.Elements = new List<T>(elements);
            this.currentIndex = 0;
        }

        public void Print()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.Elements[currentIndex]);
            }
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.Elements.Count > currentIndex + 1)
            {
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Elements.Count; i++)
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
