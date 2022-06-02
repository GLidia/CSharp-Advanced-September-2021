using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(stack.Peek());
            
        }
    }
}
