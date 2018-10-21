namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                List<Tire> tires = new List<Tire>();

                for (int i = 0; i < 4; i += 2)
                {
                    double tirePressure = double.Parse(input[5 + i]);
                    int tireAge = int.Parse(input[6 + i]);
                    tires.Add(new Tire(tireAge, tirePressure));
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                cars.Add(new Car(model, engine, cargo, tires));
                ;
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                cars.Where(c => c.Tires.Any(t => t.Pressure < 1) && c.Cargo.Type == "fragile").ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.Engine.Power > 250 && c.Cargo.Type == "flamable").ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            ;
        }
    }
}
