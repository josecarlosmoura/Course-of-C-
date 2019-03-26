using System;

namespace _06_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "josé carlos de moura e silva";

            Console.WriteLine(name.FirstLetterOfNameToUpper().Trim());

            Console.ReadKey();
        }
    }
}
