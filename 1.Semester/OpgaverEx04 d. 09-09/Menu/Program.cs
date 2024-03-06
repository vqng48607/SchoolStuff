namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
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

            switch(choice)
            {
                case 0:
                    message = "Gør dit";
                    break;

                case 1:
                    message = "Gør dat";
                    break;

                case 3:
                    message = "Gør noget";
                    break;

                case 4:
                    message = "42";
                    break;

                default:
                    message = "Forkert valg";
                    break;
            }
            Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);

            Console.ReadLine();


            /*
            if (choice == 1)
            {
                message = "Gør dit";
            }

            else if (choice == 2) 
            {
                message = "Gør dat";
            }

            else if (choice == 3)
            {
                message = "Gør noget";
            }

            else if (choice == 4)
            {
                message = "42";
            }

            else
            {
                message = "Forkert valg";
            }
            */
        }
    }
}