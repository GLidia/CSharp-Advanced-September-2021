using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;
            List<Trainer> trainers = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = data[0];
                Pokemon pokemon = new Pokemon(data[1], data[2], int.Parse(data[3]));
                
                if (trainers.Any(x => x.Name == trainerName))
                {
                    foreach (Trainer trainer in trainers.Where(x => x.Name == trainerName))
                    {
                        trainer.Pokemons.Add(pokemon);
                    }
                }
                else
                {
                    List<Pokemon> pokemons = new List<Pokemon>();
                    pokemons.Add(pokemon);
                    Trainer trainer = new Trainer(trainerName, pokemons);
                    trainers.Add(trainer);
                }
            }

            string inputTwo;

            while ((inputTwo = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == inputTwo))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                            if (trainer.Pokemons[i].Health <= 0)
                            {
                                trainer.Pokemons.Remove(trainer.Pokemons[i]);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
