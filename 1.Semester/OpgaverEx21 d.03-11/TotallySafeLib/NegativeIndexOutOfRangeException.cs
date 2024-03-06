using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallySafeLib
{
    public class NegativeIndexOutOfRangeExcenption : Exception
    {
        public NegativeIndexOutOfRangeExcenption()
        {
        }

        public NegativeIndexOutOfRangeExcenption(string message)
            : base(message)
        {
        }

        public NegativeIndexOutOfRangeExcenption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
