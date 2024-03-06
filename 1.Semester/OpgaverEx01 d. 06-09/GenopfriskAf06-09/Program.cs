namespace GenopfriskAf06_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 3.2
            Console.WriteLine("Navn: Jens Hansen");
            Console.WriteLine("Alder: 25");

            //Opgave 3.3
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Navn: {0}", name);

            Console.Write("Indtast alder: ");
            string age = Console.ReadLine();
            Console.WriteLine("Alder: {0}", age);

            Console.WriteLine("{0} er {1} år gammel", name, age);





            Console.ReadLine();

        }
    }
}