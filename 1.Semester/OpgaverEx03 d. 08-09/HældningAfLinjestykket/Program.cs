namespace HældningAfLinjestykket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opgave 3.2 og Opgave 3.3
            Console.Write("Indtast x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Indtast y2: ");
            int y2 = int.Parse(Console.ReadLine());

            // I opgave 3.2 er det bare en int
            double hældning = (double)(y2 - y1) / (x2 - x1);
            Console.Write("Hældningen er: {0}", hældning);

            Console.ReadLine();

        }
    }
}