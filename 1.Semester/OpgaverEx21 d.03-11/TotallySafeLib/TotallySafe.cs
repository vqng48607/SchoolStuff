using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            if (positionInArray < 0)
                throw new NegativeIndexOutOfRangeExcenption("There is an error, the number is too low");

            if (positionInArray >= 5)
                throw new NegativeIndexOutOfRangeExcenption("There is an error, the number is too high");
            return intArray[positionInArray];
        }
    }
}

