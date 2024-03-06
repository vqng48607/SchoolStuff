namespace Opgave2._8MenuUdenLuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string retry = "Nej";
            do 
            {

                Console.WriteLine("Min fantastiske menu");
                Console.WriteLine();

                Console.WriteLine("1. Gør dit");
                Console.WriteLine("2. Gør dat");
                Console.WriteLine("3. Gør noget");
                Console.WriteLine("4. Få svar på livet, universet og alting");
                Console.WriteLine();

                Console.WriteLine("(Tryk menupunkt 1, 2, 3 eller 4)");

                int choice = int.Parse(Console.ReadLine());

            
            
                string message;

                switch (choice)
                {
                    case 0:
                        message = "Gør dit";
                        Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
                        retry = "Nej";
                        break;

                    case 1:
                        message = "Gør dat";
                        Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
                        retry = "Nej";
                        break;

                    case 2:
                        message = "Gør noget";
                        Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
                        retry = "Nej";
                        break;

                    case 3:
                        message = "42";
                        Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
                        retry = "Nej";
                        break;

                    default:
                        message = "Ikke på listen";
                        Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
                        Console.WriteLine("Vil du prøve igen?");
                        retry = Console.ReadLine();
                        Console.Clear();
                        break;
                    
                }

            } while (retry != "Nej") ;

            Console.ReadLine();
        }
    }
}