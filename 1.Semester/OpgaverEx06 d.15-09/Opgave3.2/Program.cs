﻿using System.Security.Cryptography.X509Certificates;

namespace Opgave3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int B_age, P_age, R_age, C_age, Val_age, Vuo_age;

            Console.Write("Benjamins alder: ");
            B_age = int.Parse(Console.ReadLine());
            Console.Write("Philips alder: ");
            P_age = int.Parse(Console.ReadLine());
            Console.Write("Rubens alder: ");
            R_age = int.Parse(Console.ReadLine());
            Console.Write("Christoffers alder: ");
            C_age = int.Parse(Console.ReadLine());
            Console.Write("Valdemars alder: ");
            Val_age = int.Parse(Console.ReadLine());
            Console.Write("Vuongs alder: ");
            Vuo_age = int.Parse(Console.ReadLine());

            int[] ageArray = {B_age, P_age, R_age, C_age, Val_age, Vuo_age};

            string[] nameArray = { "Benjamin", "Philip", "Ruben", "Christoffer", "Valdemar", "Vuong" };

            int count = 0;

            float sum = ageArray[0] + ageArray[1] + ageArray[2] + ageArray[3] + ageArray[4] + ageArray[5];
            float average = sum / 6;

            Console.Clear();

            while (count < ageArray.Length)
            {
                Console.WriteLine("{0} er: {1} gammel", nameArray[count], ageArray[count]);

                count++;
            }
            Console.Write("\nGennemsnitsalder er: {0}", average);

            Console.ReadLine();
        }
    }
}