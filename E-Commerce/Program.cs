using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Load CLI\n");

            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the loan amount:");
            int amount = int.Parse(Console.ReadLine());

        }
    }
}
