using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;
        private int count;

        public int Count
        {
            get { return this.count; }
        }

        public Box()
        {
            this.count = 0;
            this.items = new List<T>();
        }

        public void Add(T element)
        {
            this.items.Add(element);
            this.count++;
        }

        public T Remove()
        {
            var itemToReturn = this.items[this.count - 1];
            this.items.RemoveAt(this.count - 1);
            count--;
            return itemToReturn;
        }
    }
}
