namespace Opgave2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2.10 og 2.11 
            Console.WriteLine("Skriv et eller andet. Programmet kører");
            string str = Console.ReadLine();
            int i = 0;

            while(i < str.Length)
            {
                char cha = str[i];
                int test = cha;


                // Hvis man skal bruge en if på færre linjer. Bruge en char tabel
                /*if(test >= 48 && test <=57)
                        Console.WriteLine("{0}: {1}", i, cha);*/

                //Hvis man gerne vil bruge switch. Nemmere at læse 
                switch(cha)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '+':
                    case '-':
                        Console.WriteLine("{0}: {1}", i, cha);

                    break;
                }
                /*default:
                        Console.WriteLine("{0}: Ukendt", i);*/
                // Sæt /* før switch og */ efter switch for lave lave opgave 2.11 nederst
                //Console.WriteLine("{0}: {1}", i, cha);

                i++;
            }
                
            Console.ReadLine();
        }
    }
}