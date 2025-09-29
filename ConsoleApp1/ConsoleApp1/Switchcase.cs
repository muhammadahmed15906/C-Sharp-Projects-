using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (age) {
                case 17:
                    Console.WriteLine(name + " You are not Eligible for Cnic");
                    break;
                case 18:
                    Console.WriteLine(name + " You are Eligible for Cnic");
                    break;
                case 19:
                    Console.WriteLine(name + " You are Eligible for Cnic");
                    break;
                default:
                    Console.WriteLine(name + " You are not Eligible for Cnic");
                    break;
            }

        }
    }
}
