namespace Opgave3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Benjamins alder: ");
            int B_age = int.Parse(Console.ReadLine());
            Console.Write("Philips alder: ");
            int P_age = int.Parse(Console.ReadLine());
            Console.Write("Rubens alder: ");
            int R_age = int.Parse(Console.ReadLine());
            Console.Write("Christoffers alder: ");
            int C_age = int.Parse(Console.ReadLine());
            Console.Write("Valdemars alder: ");
            int Val_age = int.Parse(Console.ReadLine());
            Console.Write("Vuongs alder: ");
            int Vuo_age = int.Parse(Console.ReadLine());

            float sum = B_age + P_age + R_age + C_age + Val_age + Vuo_age;

            Console.WriteLine("Summen af alle alderne er: {0}", sum);

            float average = sum / 6;

            Console.Write("Den gennemsnitlige alder er: {0}", (float)average);

            Console.ReadLine();
        }
    }
}