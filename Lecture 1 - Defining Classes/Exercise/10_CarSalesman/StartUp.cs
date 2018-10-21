using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int enginesCount = int.Parse(Console.ReadLine());
            while (enginesCount-- > 0)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                Engine engine = new Engine(tokens[0], int.Parse(tokens[1]));
                if (tokens.Length == 3)
                {
                    if (int.TryParse(tokens[2], out int displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = tokens[2];
                    }
                }
                else if (tokens.Length == 4)
                { // is it possible input to switch places of efficiency and displacement?
                    engine.Displacement = int.Parse(tokens[2]);
                    engine.Efficiency = tokens[3];
                }
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();
            int carCount = int.Parse(Console.ReadLine());
            while (carCount-- > 0)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = engines.Where(e => e.Model == tokens[1]).FirstOrDefault();
                Car car = new Car(tokens[0], engine);

                if (tokens.Length == 3)
                {
                    if (double.TryParse(tokens[2], out double weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = tokens[2];
                    }
                }
                else if (tokens.Length == 4)
                {
                    car.Weight = double.Parse(tokens[2]);

                    car.Color = tokens[3];
                }
                cars.Add(car);
            }
            cars.ForEach(c => Console.WriteLine(c));
            ;
        }
    }
}
