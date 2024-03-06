namespace Areal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast Højde: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Indtast Bredde: ");
            int width = int.Parse(Console.ReadLine());


            Console.Write("Arealet er: ");
            int areal = height * width;

            Console.WriteLine(areal);

            Console.ReadLine();
        }
    }
}