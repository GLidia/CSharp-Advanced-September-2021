using System;
using System.Collections.Generic;
using System.Text;

namespace _01_GenericBoxOfString
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

        public override string ToString()
        {
            return $"{this.type}: {this.value}";
        }
    }
}
