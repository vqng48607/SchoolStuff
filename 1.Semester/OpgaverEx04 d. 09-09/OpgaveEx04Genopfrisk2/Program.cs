namespace OpgaveEx04Genopfrisk2
{
    internal class Program
    {
        static void Main(string[] args)

        // Opgave 2.2 Forgrening med switch (menu)
        /*{
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


            switch (menuChoice)
            {
                case 1:
                    menuChoice = 1;
                    message = "Gør dit";
                    Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
                    break;

                case 2:
                    menuChoice = 2;
                    message = "Gør dat";
                    Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
                    break;

                case 3:
                    menuChoice = 3;
                    message = "Gør noget";
                    Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
                    break;

                case 4:
                    menuChoice = 4;
                    message = "42";
                    Console.WriteLine("Punkt {0} er valgt: {1}", menuChoice, message);
                    break;

                default:
                    Console.WriteLine("Forkert Valg");
                    break;
            }


            Console.ReadLine();


        }*/


        // Opgave 2.4
        /*{
            Console.WriteLine("Indlæs en vilkårlig tekststreng (på mindst seks karakterer)");
            string str = Console.ReadLine();

            char ch1 = str[1];
            char ch3 = str[3];
            char ch5 = str[5];

            Console.WriteLine("{0}, {1}, {2}", ch1, ch3, ch5);

            Console.ReadLine();

        }*/


        // Opgave 2.5: While-løkke: Gennemløb alle karakterer i en tekststreng
        /*{
            Console.WriteLine("Indlæs en vilkårlig tekststreng");
            string str = Console.ReadLine();

            int i = 0;

            while (str.Length > i)
            {
                char cha = str[i];
                Console.WriteLine("{0}: '{1}'", i, cha);

                i++;
            }

            Console.ReadLine(); 
        }*/


        // Opgave 2.7: Heltalsdivision
        {
            Console.Write("Indtast første heltal a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Indtast andet heltal b: ");
            int b = int.Parse(Console.ReadLine());


            int divisionOfaAndb = a / b;
            Console.WriteLine("a / b = {0}", divisionOfaAndb);

            double divisionOfaAndb2 = a / b;

            double divisionRemainder = (double)divisionOfaAndb2 - (double)divisionOfaAndb;

            Console.Write("Resten af divisionstykket er: {0}", divisionRemainder);

            Console.ReadLine();


        }
    }
}

