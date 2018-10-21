using System;
using System.Collections.Generic;
using System.Text;

namespace _11_PokemonTrainer
{
    public class Trainer
    {
        static int id = 0;

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public int Id { get; set; }
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
            this.Id = id++;
        }

        //public void AddPokemon(Pokemon pokemon)
        //{
        //    this.Pokemons.Add(pokemon);
        //}
    }
}
