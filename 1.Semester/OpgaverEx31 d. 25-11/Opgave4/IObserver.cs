using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Opgave4
{
    public interface IObserver
    {
        void Update(object sender, EventArgs e);
    }
}
