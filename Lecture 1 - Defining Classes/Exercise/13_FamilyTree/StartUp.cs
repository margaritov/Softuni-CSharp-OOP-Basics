namespace _13_FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        static List<Person> tree = new List<Person>();

        static void Main(string[] args)
        {
            Queue<string> relations = new Queue<string>();
            string target = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input.Contains('-') == false)
                {   // input contains information about single person
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = $"{tokens[0]} {tokens[1]}";
                    string birthday = tokens[2];
                    tree.Add(new Person(name, birthday));
                }
                else
                {
                    // input contains information about relationship between people 
                    relations.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            foreach (var relation in relations)
            {
                string[] tokens = relation.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                Person parent = GetPerson(tokens[0]);
                Person child = GetPerson(tokens[1]);

                parent.Children.Add(child);
                child.Parents.Add(parent);
            }

            PrintInfo(GetPerson(target));
            ;
        }

        private static void PrintInfo(Person person)
        {
            Console.WriteLine($"{person.Name} {person.Birthday}");
            Console.WriteLine("Parents:");
            person.Parents.ForEach(p => Console.WriteLine($"{p.Name} {p.Birthday}"));
            Console.WriteLine("Children:");
            person.Children.ForEach(p => Console.WriteLine($"{p.Name} {p.Birthday}"));
        }

        private static Person GetPerson(string data)
        {
            if (data.Contains('/') == false)
            {
                return tree.Where(p => p.Name == data).FirstOrDefault();
            }
            return tree.Where(p => p.Birthday == data).FirstOrDefault();
        }
    }
}
