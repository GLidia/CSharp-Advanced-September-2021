using System;
using System.Collections.Generic;
using System.Text;

namespace _03_GenericSwapMethodStrings
{
    public class Box<T>
    {
        private T value;
        private System.Type type;

        public Box(T value)
        {
            this.value = value;
            this.type = value.GetType();
        }

        public static void Swap(List<Box<T>> boxes, int index1, int index2)
        {
            Box<T> temp = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = temp;
        }
        public override string ToString()
        {
            return $"{this.type}: {this.value}";
        }
    }
}
