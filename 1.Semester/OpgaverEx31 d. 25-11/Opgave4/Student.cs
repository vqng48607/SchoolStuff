using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opgave4
{
    public class Student : Person, IObserver
    {
        public string Message { get; set; }

        public Student(string name): base(name) 
        {
            name = name;
        }
        
        public void Update(object sender, EventArgs e)
        {
            string aName = ((Academy)sender).Name;
            string aAddress = ((Academy)sender).Address;
            string aMessage = ((Academy)sender).Message;
            Console.WriteLine($"Studerende {Name} modtog nyhenden '{aMessage}' fra akademiet {aName}, {aAddress}");
        }
    }
}
