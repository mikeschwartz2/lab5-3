using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership
{
    class UsedCar : Car
    {
        private double miles;

        public double Miles { get => miles; set => miles = value; }

        public UsedCar(int id, string make, string model, int year, double price, double miles)
            :base (id, make, model, year, price)
        {
            this.miles = miles;
        }

        public override string ToString()
        {
            return base.ToString() + $"{miles,7} Miles  " +
                $"(USED)";
        }
    }
}
