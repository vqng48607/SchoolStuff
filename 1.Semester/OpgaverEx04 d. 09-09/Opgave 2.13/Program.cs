using System.Net.NetworkInformation;

namespace Opgave_2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.12
            char plus = (char)43;
            char minus = (char)45;

            Console.Write("Hvad skal a være?: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Vælg enten \n+ eller -: ");
            char cha =  char.Parse(Console.ReadLine());

            Console.Write("Hvad skal b være?: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Resultatet bliver: ");

            if (cha == plus)
            {
                Console.WriteLine(a + b);

            }

            else if (cha == minus)
            {
                Console.WriteLine(a - b);

            }

            else
            {
                Console.WriteLine("Ugyldigt");
            }


            Console.ReadLine();
        }
    }
}