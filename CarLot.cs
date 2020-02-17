using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership
{
    class CarLot
    {

        List<Car> cars = new List<Car>();
        private string validate;
        private int userCarID = 2000;
        private string userMake;
        private string userModel;
        private int userYear;
        private double userPrice;
        private double userMiles;

        public void addCar(Car c)
        {
            cars.Add(c);
        }
        public void AddCar()
        {
            int newUsed;

            Console.Write($"Please enter the Make of the car to be added: ");
            userMake = Console.ReadLine();
            Console.Write($"Please enter the Model of the car to be added: ");
            userModel = Console.ReadLine();
            Console.Write($"Please enter the year of the car to be added: ");
            userYear = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please enter the total price of the car: ");
            userPrice = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Please enter 1 for new car and enter 2 for used car: 1/2");
                newUsed = Convert.ToInt32(Console.ReadLine());

                if(newUsed == 1)
                {
                    cars.Add(new Car(userCarID, userMake, userModel, userYear, userPrice));
                    Console.WriteLine($"The new car has been added to inventory. ");
                }
                else if (newUsed == 2)
                {
                    Console.Write("Please enter the total number of miles on the car: ");
                    userMiles = Convert.ToDouble(Console.ReadLine());
                    cars.Add(new UsedCar(userCarID, userMake, userModel, userYear, userPrice, userMiles));
                    Console.WriteLine($"The used car has been added to inventory. ");
                }
                else 
                {
                    Console.WriteLine("This was not a valid input! ");
                }
            }
            while (newUsed != 1 && newUsed != 2);

            
            userCarID++;
        }

        public void PrintMenu()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
        }

        public void BuyCar(int carID)
        {
            bool idExists = false;
            int carCount = 0;
            foreach (Car c in cars)
            {
                
                if (c.Id == carID)
                {
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine($"You Selected");
                    Console.WriteLine(c);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine($"Would you like to purchase this car for {c.Price}? y/n");
                    validate = Validate();

                    idExists = true;
                    break;
                    carCount++;
                }

            }
            if (validate == "y")
            {
                Console.WriteLine($"Congratulations you purchased the {cars[carCount].Make}, {cars[carCount].Model}! ");
                cars.RemoveAt(carCount);

            }
            else
            {
                Console.WriteLine("You have not purchased the car :(");
            }
            if (idExists == false)
            {
                Console.WriteLine("Sorry. This car ID does not exist.");
            }
        }


        static string Validate()
        {
            string validate = Console.ReadLine();
            validate = validate.ToLower();

            while (validate != "y" && validate != "n")
            {
                Console.WriteLine("This is not a valid input. Would you like to purchase this car?: y/n");
                validate = Console.ReadLine();
                validate = validate.ToLower();
            }
            return validate;
        }

    }
}
