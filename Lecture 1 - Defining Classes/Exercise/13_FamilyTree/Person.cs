
namespace _13_FamilyTree
{
    using System;
    using System.Collections.Generic;

    class Person
    {
        public string Name { get; set; }
        public string Birthday { get; set; }
        public List<Person> Children;
        public List<Person> Parents;
        public int Id { get; }

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

       
    }
}
