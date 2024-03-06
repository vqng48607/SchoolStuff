namespace OpgaveEx03Genopfrisk2Ø4
{
    internal class Program
    {
        static void Main(string[] args)

        // Opgave 4.1: Lenght()
        /*{
            string randomString = console.ReadLine();

            Console.WriteLine(randomString.Length);

            Console.ReadLine();
        }*/


        // Opgave 4.2: Substring()
        /*{
            string randomString = "Hello, World!";
            string randomSubstring = randomString.Substring(5); 
            Console.WriteLine(randomSubstring);

            Console.WriteLine(randomSubstring.Length);

            Console.ReadLine();
        }*/

        // Opgave 4.3: IndexOf()
        {
            string randomString = "Hello, World!";
            Console.WriteLine(randomString);

            char cha = char.Parse(Console.ReadLine());

            int indexOfString = randomString.IndexOf(cha);

            if (indexOfString > 0)
                Console.WriteLine("{0} ligger på plads: {1}", cha, indexOfString);

            else
                Console.WriteLine("Karakteren blev ikke fundet");

            Console.ReadLine();
        }

    }
}