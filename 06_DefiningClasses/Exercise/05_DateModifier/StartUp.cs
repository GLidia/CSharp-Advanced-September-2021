using System;

namespace _05_DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier dm = new DateModifier(dateOne, dateTwo);
            int difference = dm.CalculateDifference();
            Console.WriteLine(difference);
        }
    }
}
