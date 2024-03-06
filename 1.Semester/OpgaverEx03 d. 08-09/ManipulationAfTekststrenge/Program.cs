namespace ManipulationAfTekststrenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 4.1
            Console.Write("Indtast en tekst: ");
            string input = Console.ReadLine();

            int length = input.Length;
            Console.WriteLine("Teksten har {0} tegn", length);

            Console.WriteLine();

            //Opgave 4.2
            string str = "Hej med dig jeg hedder Kaj";
            Console.WriteLine(str);
            Console.WriteLine("Når man så starter sætning fra tegn 5 vil der stå: ");

            string str1 = str.Substring(6);
            Console.WriteLine(str1);
            int length1 = str1.Length;
            Console.Write("Denne tekst har {0} tegn: ", length1);

            Console.ReadLine();

        }
    }
}