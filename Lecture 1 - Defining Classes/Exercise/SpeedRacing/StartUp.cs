using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            while (n-- > 0)
            {
                string[] inputData = Console.ReadLine().Split();
                string model = inputData[0];
                double fuelAmount = double.Parse(inputData[1]);
                double fuelPerKm = double.Parse(inputData[2]);
                cars.Add(new Car(model, fuelAmount, fuelPerKm));
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string model = commandArgs[1];
                int km = int.Parse(commandArgs[2]);

                cars.Where(c => c.Model == model).FirstOrDefault().Drive(km);

                command = Console.ReadLine();
            }

            cars.ForEach(c => Console.WriteLine($"{c.Model} {c.FuelAmount:F2} {c.Distance}"));
            ;
        }

    }
}
