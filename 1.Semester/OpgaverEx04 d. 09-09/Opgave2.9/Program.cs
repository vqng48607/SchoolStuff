namespace Opgave2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.9 
            Console.WriteLine("Hvor mange tegn vil du søge efter: ");
            int index1 = int.Parse(Console.ReadLine());
            int count = 1;

            Console.WriteLine("Skriv sætningen: ");
            string index2 = Console.ReadLine();

            while (count < index1)
            {
                char ch = index2[count];

                if (index1 > index2.Length)
                {
                    Console.WriteLine("Der er ikke nok tegn");
                    break;
                }

                // Eneste ændring fra 2.5 og denne er at count++ og count += 2
                Console.WriteLine("{0}: {1}", count, ch);
                count += 2;
                ch++;

            }

            Console.ReadLine();
        }
    }
}