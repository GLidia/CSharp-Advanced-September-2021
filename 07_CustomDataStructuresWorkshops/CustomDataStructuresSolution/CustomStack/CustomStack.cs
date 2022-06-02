using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.items = new int[InitialCapacity];
            this.count = 0;
        }

        public int Count 
        {
            get
            {
                return this.count;
            }
        }

        public int Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            return this.items[this.count - 1];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }

        public int Pop()
        {
            if (this.items.Length == 0)
            {
                throw new InvalidOperationException();
            }

            int toReturn = this.items[this.count - 1];
            this.items[this.count - 1] = default(int);

            count--;
            if (this.count * 4 == this.items.Length)
            {
                this.Shrink();
            }

            return toReturn;
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.items.Length / 2; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public void Push(int element)
        {
            if (this.count == this.items.Length)
            {
                this.Resize();
            }            
            
            this.items[this.count] = element;            
            count++;

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
