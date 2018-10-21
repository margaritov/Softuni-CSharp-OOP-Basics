
namespace _12_Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public List<Person> Children { get; set; }
        public List<Person> Parents { get; set; }
        public Car Car { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public Company Company { get; set; }
        public Person(string name)
        {
            this.Name = name;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
            this.Pokemons = new List<Pokemon>();
        }
        public Person(string name, string birthday)
            : this(name)
        {
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine("Company:");
            if (this.Company != null)
            {
                sb.AppendLine(this.Company.ToString());
            }

            sb.AppendLine("Car:");
            if (this.Car != null)
            {
                sb.AppendLine(this.Car.ToString());
            }
            sb.AppendLine("Pokemon:");
            if (this.Pokemons.Count > 0)
            {
                this.Pokemons.ForEach(p => sb.AppendLine(p.ToString()));
            }
            sb.AppendLine("Parents:");
            if (this.Parents.Count > 0)
            {
                this.Parents.ForEach(p => sb.AppendLine($"{p.Name} {p.Birthday}"));
            }

            sb.AppendLine("Children:");
            if (this.Children.Count > 0)
            {
                this.Children.ForEach(p => sb.AppendLine($"{p.Name} {p.Birthday}"));
            }
            return sb.ToString();
        }
    }
}
