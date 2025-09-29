using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DaySwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Day : ");
            string day = Console.ReadLine();
            switch (day) { 
                case "Monday":
                Console.WriteLine(name + " Today is Monday");
                break;
                case "Tuesday":
                Console.WriteLine(name + " Today is Tuesday");
                break;
                case "Wednesday":
                Console.WriteLine(name + " Today is Wednesday");
                break;
                case "Thursday":
                Console.WriteLine(name + " Today is Thursday");
                break;
                case "Friday":
                Console.WriteLine(name + " Today is Friday");
                break;
                case "Saturday":
                Console.WriteLine(name + " Today is Saturday");
                break;
                case "Sunday":
                Console.WriteLine(name + " Today is Sunday");
                break;
            }
        }
        }
}
