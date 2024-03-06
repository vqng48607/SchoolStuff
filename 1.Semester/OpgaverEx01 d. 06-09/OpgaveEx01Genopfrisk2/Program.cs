namespace OpgaveEx01Genopfrisk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();

            Console.WriteLine("Navn: {0}", name);

            Console.Write("Indtast alder: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Alder: {0}", age);

            Console.WriteLine("{0} er {1} år gammel", name, age);

            Console.ReadLine();
        }
    }
}