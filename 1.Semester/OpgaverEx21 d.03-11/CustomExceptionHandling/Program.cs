using System.Net.NetworkInformation;
using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(9);
                
            }
            catch (NegativeIndexOutOfRangeExcenption ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                double divider = TotallySafe.Divider(0);
                Console.WriteLine(divider);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                int stringToInt = TotallySafe.StringToInt("k");
                Console.WriteLine(stringToInt);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();


        }

    }
}