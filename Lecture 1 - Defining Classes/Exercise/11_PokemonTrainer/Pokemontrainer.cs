using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_PokemonTrainer
{
    public class PokemonTrainer
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                if (!trainers.Any(t => t.Name == trainerName))
                {
                    
                    trainers.Add(new Trainer(trainerName));

                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonHealth, pokemonElement);
                trainers.Where(t => t.Name == trainerName).FirstOrDefault().Pokemons.Add(pokemon);
                input = Console.ReadLine();
            }

            string element = Console.ReadLine();
            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }
                element = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.Badges).ThenBy(t => t.Id))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
            ;
        }
    }
}
