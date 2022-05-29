using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = new string[] { ":", "=", ">" };
            //contest + password
            Dictionary<string, string> passwords = new Dictionary<string, string>();
            string inputOne;

            while ((inputOne = Console.ReadLine()) != "end of contests")
            {
                string[] data = inputOne.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string contest = data[0];
                string password = data[1];

                passwords.Add(contest, password);

            }

            //username + (contest + points)
            Dictionary<string, Dictionary<string, double>> grades = new Dictionary<string, Dictionary<string, double>>();
            string inputTwo;

            while ((inputTwo = Console.ReadLine()) != "end of submissions")
            {
                //"{contest}=>{password}=>{username}=>{points}" 
                string[] info = inputTwo.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string contest = info[0];
                string password = info[1];
                string username = info[2];
                double points = double.Parse(info[3]);

                if (passwords.ContainsKey(contest) && passwords[contest] == password)
                {
                    if (!grades.ContainsKey(username))
                    {
                        grades.Add(username, new Dictionary<string, double>());
                    }

                    if (!grades[username].ContainsKey(contest))
                    {
                        grades[username].Add(contest, points);
                    }
                    else
                    {
                        if (points > grades[username][contest])
                        {
                            grades[username][contest] = points;
                        }
                    }
                }

            }

            double maxPoints = 0;
            string bestCandidate = string.Empty;

            foreach (var user in grades)
            {
                double currentPoints = 0;
                foreach (var contest in user.Value)
                {
                    currentPoints += contest.Value;
                }

                if (currentPoints > maxPoints)
                {
                    maxPoints = currentPoints;
                    bestCandidate = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in grades.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
