using System;
using System.Collections.Generic;
using System.Text;

namespace _06_GenericCountMethodDouble
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

        public static int Compare<T>(List<Box<T>> boxes, T valueToCompare)
        {
            int count = 0;

            foreach (Box<T> box in boxes)
            {

                if (Comparer<T>.Default.Compare(box.value, valueToCompare) > 0)
                {
                    count++;
                }

            }

            return count;
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
