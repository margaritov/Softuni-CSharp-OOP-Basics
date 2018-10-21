using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // DateModifier task
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            //int diff = DateModifier.CalculateDifference(s1, s2);
            //Console.WriteLine(diff);

            List<Employee> employees = new List<Employee>();

            //string pattern = @"^(?<name>[A-Za-z]+) (?<salary>\d+.\d+) (?<position>\w+) (?<department>\w+)\s*(?<email>[A-Za-z0-9]+@[A-Za-z0-9]+.\w+)*\s*(?<age>\d+)*$";

            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];
                Employee employee = new Employee(name, salary, position, department);

                if (inputArgs.Length == 5)
                {
                    if (int.TryParse(inputArgs[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = inputArgs[4];
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    employee.Email = inputArgs[4];
                    employee.Age = int.Parse(inputArgs[5]);
                }
                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(e => e.Department)
                                            .ToDictionary(x => x.Key, y => y.Select(s => s))
                                            .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                            .FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");
            foreach (var employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
            ;
        }
    }
}
