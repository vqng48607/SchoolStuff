using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opgave4
{
    public delegate void EventHandler(object sender, EventArgs e);
    public class Academy : Organization, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; PropertyChanged.Invoke(this, null); }
        }


        public Academy(string name, string address): base (name)
        {
            name = name;
            Address = address;
        }


        public void Attach(IObserver o)
        {
            PropertyChanged += o.Update;
        }

        public void Detach(IObserver o)
        {
            PropertyChanged -= o.Update;
        }

        public void OnMessageChanged()
        {
            PropertyChanged.Invoke(this, null);
        }
    }
}
