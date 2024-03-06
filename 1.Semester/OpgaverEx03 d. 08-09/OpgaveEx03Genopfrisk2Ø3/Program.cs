namespace OpgaveEx03Genopfrisk2Ø3
{
    internal class Program
    {
        static void Main(string[] args)

        // Opgave 3.1: Rektanglets areal. Fjern alle /* */ for at teste koden
        /*{
            Console.Write("Angiv længeden på højden: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Angiv bredden på rektanglet: ");
            int Base = int.Parse(Console.ReadLine());

            int area = height * Base;
            Console.WriteLine("Arealet af rektanglet er: {0}", area);
            
        }*/

        // Opgave 3.2: Hældning af linjestykke
        {
            Console.Write("Angiv startpunkt for X1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Angiv startpunkt for Y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Angiv slutpunkt for X2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Angiv startpunkt for Y1: ");
            int y2 = int.Parse(Console.ReadLine());

            double slope = (double)(y2 - y1) / (double)(x2 - x1);

            Console.Write("Hældning af linjestykket er: {0}", slope);

            Console.ReadLine();
        }

    }
}