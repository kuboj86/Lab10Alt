using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList vehicles = new ArrayList();
            ArrayList carCart = new ArrayList();

            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-");
            Console.WriteLine("Welcome to Electric Avenue");
            Console.WriteLine("~-~-~-~-~-~-~-~-~-~-~-~-~-\n");

            vehicles.Add(new Car());
            vehicles.Add(new Car("Nissan", "Leaf", 2017, 30495));
            vehicles.Add(new Car("Chevy", "Spark", 2017, 25_995));
            vehicles.Add(new Car("BMW", "i3", 2017, 41_450));
            vehicles.Add(new Car("Tesla", "Model S", 2017, 75_00));
            vehicles.Add(new UsedCar("Ford", "Focus", 2014, 13_475, 53_760 ));
            vehicles.Add(new UsedCar("Toyota", "Prius", 2013, 12_199, 85_345));
            vehicles.Add(new UsedCar("Pontiac", "Aztec", 2011, 4789, 164_739));


            bool orderMore = true;
            while (orderMore)
            {
                Console.WriteLine("Item # \tMake\tModel\tYear\tPrice\tMiles\n~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~");

                for (int i = 0; i < vehicles.Count; i++)
                {
                    Console.WriteLine($"{i + 1}| \t{vehicles[i]}");
                }
                int selection = GetValue(vehicles.Count);

                Car selectedCar = (Car) vehicles[selection];
 
                Console.WriteLine($"You have selected the {selectedCar.Year} {selectedCar.Make} {selectedCar.Model} for ${selectedCar.Price}. Is this the vehicle you want today?  y/n");
                orderMore = GetYesNo();
               
                vehicles.RemoveAt(selection);

                Console.WriteLine("Congratulations on your new car!");
            } 
        }
        private static int GetValue(int vehicleCount)
        {
            int selection;
            while (true)
            {
                Console.WriteLine($"\nWhich vehicle would you like to purchase today?\nSelect the vehicle by the Item #(1-{vehicleCount})");
                string input = Console.ReadLine();
                if (int.TryParse(input, out selection))
                {
                    if (selection > 1 && selection <= vehicleCount)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That selection is out of range.");
                    }
                }
                else
                {
                    Console.WriteLine($"Please enter a valid input (1-{vehicleCount}");
                }

            }
            return selection - 1;
        }
        private static bool GetYesNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "n")
                {
                    valid = false;
                    repeat = true;
                }
                else if (response == "y")
                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Not a valid response. Please enter \"y\" or \"n\". ");
                }
            }
            return repeat;
        }
    }
}
