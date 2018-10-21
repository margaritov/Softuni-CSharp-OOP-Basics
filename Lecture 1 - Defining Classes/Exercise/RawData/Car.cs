using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {

        //You are the owner of a courier company and want to make a system for tracking your cars and their cargo. Define a class Car that holds an information about model, engine, cargo and a collection of exactly 4 tires. The engine, cargo and tire should be separate classes. Create a constructor that receives all of the information about the Car and creates and initializes its inner components (engine, cargo and tires).

        //    On the first line of input you will receive a number N - the amount of cars you have.On each of the next N lines you will receive an information about a car in the format “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” where the speed, power, weight and tire age are integers, tire preassure is a double. 

        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }
        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }

            set
            {
                this.tires = value;
            }
        }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
