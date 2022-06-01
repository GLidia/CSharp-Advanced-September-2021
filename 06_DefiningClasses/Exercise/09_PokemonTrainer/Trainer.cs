using System;
using System.Collections.Generic;
using System.Text;

namespace _09_PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Pokemons = pokemons;
            this.Badges = 0;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}
