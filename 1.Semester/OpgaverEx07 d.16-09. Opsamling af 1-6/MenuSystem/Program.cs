namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu mainMenu = new Menu("Min fantastiske menu");
            
            mainMenu.AddMenuItem("1. Gør diit");
            mainMenu.AddMenuItem("2. Gør dat");
            mainMenu.AddMenuItem("3. Gør noget");
            mainMenu.AddMenuItem("4. Få svar på livet, universet og alting");

            int close = 1;
            do
            {
                mainMenu.Show();
                close = mainMenu.SelectMenuItem();
                Console.Clear();
            } while (close != 0);



        }
    }
}