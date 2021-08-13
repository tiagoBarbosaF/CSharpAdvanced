using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 6, 1, 8, 13, 19, 32, 10, 55, 190, 1100, 2, 78 };

            var filterList = list.Where(x => x > 10).OrderByDescending(x => x).Select(x => x);
            var filterList02 = from x in list where x > 5 orderby x descending select x;

            foreach (var item in filterList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var item in filterList02)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
