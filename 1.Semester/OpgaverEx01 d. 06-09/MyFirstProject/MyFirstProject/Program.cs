namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Indtast navn: ");    
            string fornavn = Console.ReadLine();
            Console.WriteLine("Fornavn: " + fornavn);

            Console.Write("Indtast alder: ");
            string alder = Console.ReadLine();
            Console.WriteLine("Alder: " + alder);
            Console.WriteLine(fornavn + " er " + alder + " år gammel ");

        }
    }
}