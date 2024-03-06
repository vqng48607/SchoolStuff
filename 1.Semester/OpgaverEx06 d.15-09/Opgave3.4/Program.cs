using System;
using System.Diagnostics.Metrics;

namespace Opgave3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;


            try
            {
                Console.Write("Hvor mange personer er der: ");
                int AntalPersoner = int.Parse(Console.ReadLine());


                int[] ageArray = new int[AntalPersoner];

                while (count < AntalPersoner)
                {
                    Console.WriteLine("Hvor gammel er person {0}: ", count);
                    ageArray[count] = int.Parse(Console.ReadLine());
                    count++;
                }

                Console.Clear();

                count = 0;
                while (count < AntalPersoner)
                {
                    Console.WriteLine("Person {0} er {1} år ", count, ageArray[count]);
                    count++;
                }
            }
            catch 
            {
                Console.WriteLine("Invalid age value");
            }

            Console.ReadLine();
        }
    }
}