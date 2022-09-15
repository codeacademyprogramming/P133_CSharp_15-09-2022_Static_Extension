using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Extensions
{
    static class Extension
    {
        public static int Pow(this int num, int pow)
        {
            int result = 1;
            int i = 0;

            while (i < pow)
            {
                result *= num;
                i++;
            }

            return result;
        }

        public static bool CheckStr(this string str,char symbol)
        {
            return str.Contains(symbol);
        }
    }
}
