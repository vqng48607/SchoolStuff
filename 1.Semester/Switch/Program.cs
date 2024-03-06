using System;
using System.Runtime.InteropServices;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            int menuinput = int.Parse(Console.ReadLine());

            switch (menuinput)
            {
                case 0:
                    Console.WriteLine("Du har valgt sushi");
                    break;
                case 1:
                    Console.WriteLine("Du har valgt burger");
                    break;
                case 2:
                    Console.WriteLine("Du har valgt rygbrød");
                    break;
                case 3:
                    Console.WriteLine("Du har valgt pho");
                    break;

                default:
                    Console.WriteLine("Du har ikke valgt noget");
                    break;
            }

            Console.ReadLine();
        }
    }
}