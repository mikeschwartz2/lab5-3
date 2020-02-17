using System;
using System.Collections.Generic;

namespace CarDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            string rerun = "";
            int carID;
            int menuSelect;
            CarLot carLot = new CarLot();

            carLot.addCar(new Car(1001, "Ford", "Explorer", 2020, 60000));
            carLot.addCar(new Car(1002, "Ford", "Focus", 2019, 20000));
            carLot.addCar(new Car(1003, "Chevy", "Malibu", 2019, 23000));
            carLot.addCar(new Car(1004, "Chevy", "Impala", 2020, 50000));
            carLot.addCar(new Car(1005, "Jeep", "Patriot", 2018, 14000));
            carLot.addCar(new Car(1006, "Jeep", "Liberty", 2020, 70000));
            carLot.addCar(new UsedCar(1007, "Chevy", "Malibu", 2003, 90000, 40000));
            carLot.addCar(new UsedCar(1008, "Jeep", "Liberty", 2010, 30000, 50000));
            carLot.addCar(new UsedCar(1009, "Ford", "Fusion", 2011, 24000, 60000));

            Console.WriteLine($"Hello, Welcome to Dev Build Car Dealership");
            carLot.PrintMenu();
            do
            {
                menuSelect = MenuSelect();

                if(menuSelect == 1)
                {
                    carID = GetID();
                    carLot.BuyCar(carID);

                }
                else if(menuSelect == 2)
                {
                    carLot.AddCar();
                }
                else if (menuSelect == 3)
                {
                    carLot.PrintMenu();
                }
                else
                {
                    break;
                }

                rerun = Rerun(rerun);
            }
            while (rerun == "y");

        }

        static string Rerun(string rerun)
        {
            Console.WriteLine("Would you like to continue? y/n");
            rerun = Console.ReadLine();
            rerun = rerun.ToLower();

            while (rerun != "y" && rerun != "n")
            {
                Console.WriteLine("This is not a valid input. Would you like to continue: y/n");
                rerun = Console.ReadLine();
                rerun = rerun.ToLower();
            }
            return rerun;
        }

        static int GetID()
        {
            int getID;
            bool worked;
            do
            {
                Console.Write("Please enter the ID of the car you would like to buy: ");
                worked = int.TryParse(Console.ReadLine(), out getID);
                if (!worked)
                {
                    Console.WriteLine("Sorry, this is not a valid input. Please enter a valid car ID.");
                }
            } while (!worked);
            return getID;
        }

        static int MenuSelect()
        {
            int menuSelect;
            bool worked;
            do
            {
                Console.WriteLine("=================================================================================");
                Console.WriteLine("Please select what you would like to do. Enter 1-4: ");
                Console.WriteLine("1. Buy Car");
                Console.WriteLine("2. Add Car");
                Console.WriteLine("3. List All Cars");
                Console.WriteLine("4. Quit");
                worked = int.TryParse(Console.ReadLine(), out menuSelect);
                if (!worked)
                {
                    Console.WriteLine("Sorry, this is not a valid input. Please enter a valid menu choice");
                }
            } while (!worked);
            return menuSelect;
        }



    }
}
