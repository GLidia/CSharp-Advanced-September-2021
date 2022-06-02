using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Tuple
{
    public class Tuple<T, V>
    {
        public T Item1 { get; set; }
        public V Item2 { get; set; }

        public Tuple(T item1, V item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
    }
}
