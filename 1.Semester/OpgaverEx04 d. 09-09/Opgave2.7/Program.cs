namespace Opgave2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv et heltal: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv endnu et heltal: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Resultat: a/b giver: ");
            int regn1 = a / b;
            Console.WriteLine(regn1);

            Console.Write("Restedende: a/b: ");
            double regn2 = (double) a / b;

            Console.WriteLine(regn2 - regn1);


            Console.ReadLine();


        }
    }
}