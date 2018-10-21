
namespace _12_Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                if (!persons.ContainsKey(name))
                {
                    persons.Add(name, new Person(name));
                }

                string item = tokens[1];
                switch (tokens[1])
                {
                    case "pokemon":

                        string pokemonName = tokens[2];
                        string pokemonElement = tokens[3];
                        persons[name]
                               .Pokemons
                               .Add(new Pokemon(pokemonName, pokemonElement));
                        break;

                    case "company":
                        string companyName = tokens[2];
                        string companyDept = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);
                        Company company = new Company(companyName, companyDept, salary);
                        persons[name].Company = company;
                        break;

                    case "car":
                        Car car = new Car(tokens[2], int.Parse(tokens[3]));
                        persons[name].Car = car;
                        break;

                    case "children":
                        string childName = tokens[2];
                        string childBirthday = tokens[3];
                        if (!persons.ContainsKey(childName))
                        {
                            Person child = new Person(childName, childBirthday);
                            child.Parents.Add(persons[name]);
                            persons[name].Children.Add(child);
                        }
                        else
                        {
                            persons[childName].Birthday = childBirthday;
                            persons[childName].Parents.Add(persons[name]);
                            persons[name].Children.Add(persons[childName]);
                        }
                        break;
                    case "parents":
                        string parentName = tokens[2];
                        string parentBirthday = tokens[3];

                        if (!persons.ContainsKey(parentName))
                        {
                            Person parent = new Person(parentName, parentBirthday);
                            parent.Children.Add(persons[name]);
                            persons[name].Parents.Add(parent);
                        }
                        else
                        {
                            persons[parentName].Birthday = parentBirthday;
                            persons[parentName].Children.Add(persons[name]);
                            persons[name].Parents.Add(persons[parentName]);
                        }

                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            string targetName = Console.ReadLine();
            Person target = persons[targetName];
            Console.WriteLine(persons[targetName]);
            ;
        }
    }
}
