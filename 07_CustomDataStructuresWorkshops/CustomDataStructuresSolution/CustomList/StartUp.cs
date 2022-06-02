using System;

namespace CustomList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(default(int));
        }
    }
}
