using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Marks : ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if(marks >= 90)
            {
                Console.WriteLine(name + " your grade is A+");
            }else if(marks >= 80)
            {
                Console.WriteLine(name + " your grade is A+");
            }else if(marks >= 70){
                Console.WriteLine(name + " your grade is A");
            }else if(marks >= 60)
            {
                Console.WriteLine(name + " your grade is B");
            }else if(marks >= 50)
            {
                Console.WriteLine(name + " your grade is C");
            }else if(marks >= 40)
            {
                Console.WriteLine(name + " your grade D");
            }
            else
            {
               Console.WriteLine(name + " your grade is F means you are Fail");
            }
        }
    }
}
