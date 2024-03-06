using System.ComponentModel.Design;

namespace OpgaveEx02Genopfrisk2
{
    internal class Program
    {
        static void Main(string[] args)

        //Direkte til opgave 4. Fjern alle /* */ for at teste opgaven

        /*{
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();

            Console.WriteLine("Navn: {0}", name);

            Console.Write("Indtast alder: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Alder: {0}", age);

            string ageTitle = "";

            if (age < 13)
                ageTitle = "et barn";
            else if (age < 20)
                ageTitle = "en teenager";
            else if (age < 26)
                ageTitle = "en studerende";
            else if (age < 68)
                ageTitle = "i arbejde";
            else if (age > 67)
                ageTitle = "en pensionist";

            Console.WriteLine("{0} er {1} år gammel og er {2}", name, age, ageTitle);

            Console.ReadLine();
        }*/



        // Opgave 5 Menu me if else

        {
            Console.WriteLine("Min fantastike menu:");
            Console.WriteLine("");

            Console.WriteLine(" 1. Gør dit");
            Console.WriteLine(" 2. Gør dat");
            Console.WriteLine(" 3. Gør noget");
            Console.WriteLine(" 4. Få svaret på livet, universet og alting");
            Console.WriteLine();

            Console.WriteLine("(Tryk menupunkt 1, 2, 3 eller 4)");

            int menuChoice = int.Parse(Console.ReadLine());
            string message = "";


            if (menuChoice == 1)
            {
                menuChoice = 1;
                message = "Gør dit";
                Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
            }
            else if (menuChoice == 2)
            {
                menuChoice = 2;
                message = "Gør dat";
                Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
            }
            else if (menuChoice == 3)
            {
                menuChoice = 3;
                message = "Gør noget";
                Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
            }
            else if (menuChoice == 4)
            {
                menuChoice = 4;
                message = "42";
                Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
            }
            else
                Console.WriteLine("Forkert Valg");
                

            Console.ReadLine();


        }

            
    }
}