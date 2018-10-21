using System;
using System.Collections.Generic;
using System.Text;

namespace _10_CarSalesman
{
    public class Car
    {
        //A Car has a model, engine, weight and color A Car’s weight and color and its Engine’s displacements and efficiency are optional. 
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, double weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder($"{this.Model}:\r\n");
            result.Append($"  {this.Engine.Model}:\r\n");
            result.Append($"    Power: {this.Engine.Power}\r\n");

            string displacementStr = this.Engine.Displacement == -1 ? "n/a" : this.Engine.Displacement.ToString();
            result.Append($"    Displacement: {displacementStr}\r\n");
            result.Append($"    Efficiency: {this.Engine.Efficiency}\r\n");


            string weightStr = this.Weight == -1 ? "n/a" : this.Weight.ToString();
            result.Append($"  Weight: {weightStr}\r\n");
            result.Append($"  Color: {this.Color}");
            return result.ToString();
        }
    }
}