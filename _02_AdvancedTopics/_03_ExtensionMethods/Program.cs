using System;
using _03_ExtensionMethods.Lib.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "hello world!";

            Console.WriteLine(value.FirstToUpper());
        }
    }
}
