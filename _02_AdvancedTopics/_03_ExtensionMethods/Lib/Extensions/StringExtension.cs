using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods.Lib.Extensions
{
    public static class StringExtension
    {
        public static string FirstToUpper(this string str)
        {
            var first = str.Substring(0, 1);
            var second = str.Substring(1);

            return first.ToUpper() + second;
        }
    }
}
