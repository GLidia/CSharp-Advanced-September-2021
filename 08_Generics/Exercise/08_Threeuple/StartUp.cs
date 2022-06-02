using System;

namespace _08_Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] nameAddress = Console.ReadLine().Split();
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(nameAddress[0] + " " + nameAddress[1], nameAddress[2], nameAddress[3]);

            string[] litersOfBeer = Console.ReadLine().Split();
            bool isDrunk = false;
            if (litersOfBeer[2] == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(litersOfBeer[0], int.Parse(litersOfBeer[1]), isDrunk);

            string[] bankInfo = Console.ReadLine().Split();
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);

            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
