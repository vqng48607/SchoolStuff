using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shift(this string str, int shift)
        {
            if (str != null)
            {


                if (str.Length < shift || -str.Length < -shift)
                {
                    if (shift < 0)
                    {
                        shift = shift + str.Length;
                    }

                    else if (shift > 0)
                    {
                        shift = shift - str.Length;
                    }
                }

                if (shift < 0)
                {
                    shift = -shift;
                    return str[shift..] + str[..shift];
                }
                else if (shift > 0)
                {
                    return str[(str.Length - shift)..] + str[..(str.Length - shift)];
                }
                else if (shift == 0)
                {
                    return str;
                }
                else
                    return "";
            }
            else
                return "";
        }

        public static int Age(this DateTime dt, DateTime referreferenceDate)
        {
            if (dt >= referreferenceDate)
            {
                return 0;
            }
            else if((referreferenceDate - dt).Days < 366)
            {
                return 0;
            }
            else
            {
                int compare = referreferenceDate.Year - dt.Year;
                return compare;
            }
        }
        public static int Age(this DateTime dt)
        {
            int compare = DateTime.Now.Year - dt.Year;
            return compare;

           
        }
    }
}
