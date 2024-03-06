namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 4.3, bemærk der ikke er blevet benyttet char til opgaven

            Console.WriteLine("Indtast en tekst der indeholder bogstaven a: ");
            string input = Console.ReadLine();

            int index1 = input.IndexOf("a");

            if (index1 < 0)
            {
                string input2 = "a blev ikke fundet";
                Console.WriteLine(input2);
            }

            else
            {
                Console.WriteLine("a befinder sig på plads: ");
                Console.WriteLine(index1);
            }


            Console.ReadLine();
        }
    }
}