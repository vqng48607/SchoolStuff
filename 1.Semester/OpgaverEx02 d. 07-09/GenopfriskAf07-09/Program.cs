namespace GenopfriskAf07_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 3.2
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();

            Console.Write("Indtast alder: ");
            int age = int.Parse(Console.ReadLine());

            // For at lave opgave 3.3 skal denne ændring laves. Altså at man trækker 10 fra alder
            int age1 = age - 10;

            Console.WriteLine("{0} er {1} år gammel", name, age);

            Console.ReadLine();


        }
    }
}