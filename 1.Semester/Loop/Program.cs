namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            while (count < number)
            {
                Console.WriteLine("Number: {0} ", count);
                count++;
            }
            Console.ReadLine();
        }
    }
}