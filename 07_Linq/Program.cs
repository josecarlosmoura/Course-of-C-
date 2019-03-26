using System;
using System.Linq;

namespace _07_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "jose", "maria", "joao", "adriele", "simone", "tulio", "fernanda" };

            //var listNamesSelected = names.Where(x => !x.Contains("e")).OrderByDescending(x => x).Select(x => x);

            var listNamesSelected = from x in names where !x.Contains("e") orderby x select x;

            foreach (var item in listNamesSelected)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
