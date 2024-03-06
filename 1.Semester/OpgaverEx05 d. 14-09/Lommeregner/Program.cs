namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et tal: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv endnu et tal: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Vil du +, -, / eller *");
            string tegn = Console.ReadLine();

            Calculator calculator = new Calculator();

            if (tegn == "+")
            {
                Console.WriteLine(calculator.Add(x, y));
            }

            else if (tegn == "-")
            {
                Console.WriteLine(calculator.Subtract(x, y));
            }

            else if (tegn == "/")
            {
                Console.WriteLine(calculator.Divide(x, y));
            }

            else if (tegn == "*")
            {
                Console.WriteLine(calculator.Multiply(x, y));
            }

            Console.ReadLine();
        }
    }
}