using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Employee
    {
        //: name, salary, position, department, email and age. The name, salary, position and department are mandatory while the rest are optional. 
        string name;
        string email;
        int age;
        string position;
        string department;
        decimal salary;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }

        }

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }



        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Age = -1;
            this.Email = "n/a";
        }
        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            this.Email = email; 
        }

        public Employee(string name, decimal salary, string position, string department, int age)
             : this(name, salary, position, department)
        {
            this.Age = age;
        }
        public Employee(string name, decimal salary, string position, string department, string email, int age)
           : this(name, salary, position, department,email)
        {
            this.Age = age;
        }


        public override string ToString()
        {
            return $"{this.Name} {this.Salary:F2} {this.Position} {this.Department} {this.Email}";
        }
    }
}
