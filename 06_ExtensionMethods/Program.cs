using System;

namespace _06_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "maria da silva sauro";

            Console.WriteLine(name.FirstLetterOfNameToUpper().Trim());

            Console.ReadKey();
        }
    }
}
