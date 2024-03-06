namespace Thread_opgave_3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(WriteHelloWorld);
            t1.Start("Hello World (metode)");


            Thread t2 = new Thread((object obj) =>
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(obj);
                }
            });
            t2.Start("Hello World (lambda)");


            Thread t3 = new Thread(delegate (object obj)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(obj);
                }
            });
            t3.Start("Hello World (anomyn)");





            Console.ReadLine();
        }

        static void WriteHelloWorld(object obj)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
