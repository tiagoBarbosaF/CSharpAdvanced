using System;
using System.Linq;

namespace _04_LinqDistinctAndGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = { 1, 1, 1, 1, 4, 4, 3, 3, 6, 6, 6, 2, 2, 2, 5, 7, 7, 7, 10, 9, 9, 9, 8, 8, 8, 8, 8, 8 };

            // DISTINCT
            var filteredList01 = numberList.Distinct().OrderBy(x => x).Select(x => x);
            var filteredList02 = numberList.OrderBy(x => x).GroupBy(x => x).Select(x => x);

            Console.Write("Distinct => ");
            foreach (var item in filteredList01)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Group By => ");
            foreach (var item in filteredList02)
            {
                Console.Write(item.Key + " ");
            }
            Console.ReadKey();
        }
    }
}
