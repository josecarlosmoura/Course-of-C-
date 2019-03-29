using System;
using System.Threading;

namespace _13_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread threadOne = new Thread(ShowNumbers);
            threadOne.Start();

            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"Number out thread - {i}");
            }

            Console.ReadKey();
        }

        private static void ShowNumbers()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine($"Number - {i}");
            }
        }
    }
}
