﻿namespace Opgave2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange tegn vil du søge efter: ");
            int index1 = int.Parse(Console.ReadLine());
            int count = 0;

            Console.WriteLine("Skriv sætningen: ");
            string index2 = Console.ReadLine();

            while (count < index1)
            {
                char ch = index2[count];

                if (index1 > index2.Length)
                {
                    Console.WriteLine("Der er ikke nok tegn");
                    break;
                }

                Console.WriteLine("{0}: {1}", count, ch);
                count++;
                ch++;

            }

            Console.ReadLine();
        }
    }
}