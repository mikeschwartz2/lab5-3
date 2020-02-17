using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership
{
    class Car
    {
        private int id;
        private string make;
        private string model;
        private int year;
        private double price;

        public int Id { get => id; set => id = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car(int id, string make, string model, int year, double price)
        {
            this.id = id;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public override string ToString()
        {
            return $"ID: {id,-6} {make,-8} {model,-10} Year: {year,-4} ${price,-8}";
        }


    }
}
