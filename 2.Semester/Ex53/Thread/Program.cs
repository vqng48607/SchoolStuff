using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(WriteHelloWorld);
            t1.Start();


            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Hello World (lambda)");
                }
            });
            t2.Start();


            Thread t3 = new Thread(delegate()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Hello World (anomyn)");
                }
            });
            t3.Start();

           
 
            

            Console.ReadLine();
        }

        static void WriteHelloWorld()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hello World (metode)");
            }
        }
    }
}