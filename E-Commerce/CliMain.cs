using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    class CliMain
    {


        void MainMenu()
        {

            Console.WriteLine("Welcome to E-comm Command Line Application");
            Console.WriteLine("\n Please Choose an Option");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Regiter");
            Console.WriteLine("3.Exit\n");
            Console.WriteLine("Your option:");

            int option = int.Parse(Console.ReadLine());

        }


        static void Main(string[] args)
        {

            CliMain main = new CliMain();
            main.MainMenu();

        }
    }
}
