using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    internal class Menu
    {
        public string Title;
        private MenuItem[] menuItems = new MenuItem[10];
        private int itemCount = 0;

        public void Show()
        {

            Console.WriteLine(Title);

            Console.WriteLine();

            Console.WriteLine("  {0}", menuItems[0].Title);
            Console.WriteLine("  {0}", menuItems[1].Title);
            Console.WriteLine("  {0}", menuItems[2].Title);
            Console.WriteLine("  {0}", menuItems[3].Title);
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunkt eller 0 for at afslutte)");

        }

        public void AddMenuItem(string menuTitle)
        {

            // Menu item
            MenuItem mi = new MenuItem(menuTitle);
            mi.Title = menuTitle;
            menuItems[itemCount] = mi;
            itemCount++; // Increment with one; same as: ItemCount = ItemCount + 1
        }

        public Menu(string title)
        {
            Title = title;
        }

        public int SelectMenuItem()
        {
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);

            Console.Clear();


            switch (number)
            {
                case 0:
                    Console.Clear();
                    return number;
                case 1:
                    Console.WriteLine("Gør dit");
                    break;
                case 2:
                    Console.WriteLine("Gør dat");
                    break;
                case 3:
                    Console.WriteLine("Gør noget");
                    break;
                case 4:
                    Console.WriteLine("42");
                    break;
                default:
                    Console.WriteLine("Forkert input, tryk enter for at prøve igen");
                    break;
                    
            }
            Console.ReadLine();
            return number;

        }
    }
}
