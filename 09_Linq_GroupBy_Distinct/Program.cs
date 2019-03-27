using System;
using System.Linq;

namespace _09_Linq_GroupBy_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfNumbers = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 10, 9, 8, 4, 6, 7, 43 };

            // Distinct
            //var listFiltered = listOfNumbers.Distinct().OrderBy(x => x).Select(x => x);

            // GroupBy
            var listFiltered = listOfNumbers.OrderBy(x => x).GroupBy(x => x).Select(x => x);

            foreach (var item in listFiltered)
            {
                Console.WriteLine(item.Key);
            }
            Console.ReadKey();
        }
    }
}
