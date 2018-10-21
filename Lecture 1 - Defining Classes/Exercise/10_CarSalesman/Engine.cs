﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _10_CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }


        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = -1;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

       
           
        
    }
}
