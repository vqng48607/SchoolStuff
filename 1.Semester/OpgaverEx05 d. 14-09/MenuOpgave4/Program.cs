namespace MenuOpgave4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retry;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Hvad vil du?: ");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. /");
                Console.WriteLine("4. *");
                Console.Write("Vælg dit et nummer: ");
                int answer = int.Parse(Console.ReadLine());

                int x = 0;
                int y = 0;

                if (answer <= 4 && answer >= 1)
                {
                    Console.Write("Skriv et tal: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Skriv endnu et tal: ");
                    y = int.Parse(Console.ReadLine());
                }

                Calculator calculator = new Calculator();

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Resultatet bliver: {0}", calculator.Add(x, y));
                        break;

                    case 2:
                        Console.WriteLine("Resultatet bliver: {0}", calculator.Subtract(x, y));
                        break;

                    case 3:
                        Console.WriteLine("Resultatet bliver: {0}", calculator.Divide(x, y));
                        break;

                    case 4:
                        Console.WriteLine("Resultatet bliver: {0}", calculator.Multiply(x, y));
                        break;

                    default:
                        Console.WriteLine("Virker ikke");
                        break;
                }
                Console.WriteLine("Vil du prøve igen? Ja/Nej");
                retry = Console.ReadLine();
                retry = retry.ToLower();
                Console.Clear();
            } while (retry != "nej");


            Console.ReadLine();
        }
    }
}