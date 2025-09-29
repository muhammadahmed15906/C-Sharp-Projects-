using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Category");
            Console.WriteLine("1. Food");
            Console.WriteLine("2. Drinks");
            int category = Convert.ToInt32(Console.ReadLine());
            switch (category) {
                case 1:
                    Console.WriteLine("Choose Food Item : ");
                    Console.WriteLine("Pizza");
                    Console.WriteLine("Burger");
                    string food = Console.ReadLine();
                    switch (food) {
                        case "Pizza":
                            Console.WriteLine("You have selected Pizza");
                            break;
                        case "Burger":
                            Console.WriteLine("You have selected Burger");
                            break;
                        default:
                            Console.WriteLine("Invalid Food Item");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Choose Drink Item : ");
                    Console.WriteLine("Soft Drinks");
                    Console.WriteLine("Shakes");
                    Console.WriteLine("Coffee");
                    string drink = Console.ReadLine();
                    switch (drink) {
                        case "Soft Drinks":
                            Console.WriteLine("You have selected Soft Drinks");
                            break;
                        case "Shakes":
                            Console.WriteLine("You have selected Shakes");
                            break;
                        case "Coffee":
                            Console.WriteLine("You have selected Coffee");
                            break;
                        default:
                            Console.WriteLine("Invalid Drink Item");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid Category");
                    break;
            }
        }
    }
}
