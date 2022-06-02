using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            
            if (firstIndex >= Count || secondIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            int temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }

        public bool Contains(int element)
        {
            bool isContained = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == element)
                {
                    isContained = true;
                }
            }

            return isContained;
        }

        public void Insert(int index, int element)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            Count++;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            int toReturn = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);
            Count--;

            if (this.Count * 4 <= this.items.Length)
            {
                this.Shrink();
            }

            return toReturn;
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        public void Add(int element)
        {
            if (this.items.Length == this.Count)
            {
                this.Resize();
            }

            this.items[this.Count] = element;
            this.Count++;
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}
