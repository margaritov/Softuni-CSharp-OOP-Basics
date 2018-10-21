namespace _12_Google
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public Pokemon(string name, string element)
        {
            this.Name = name;
            this.Element = element;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Element}";
        }
    }
}
