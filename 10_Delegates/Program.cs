using System;

namespace _10_Delegates
{
    class Program
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc = new Calculate(Sum);
            int so = calc(50, 30);

            Calculate calcOne = new Calculate(Subtract);
            int su = calc(87, 10);

            Console.WriteLine("Sum:" + so);
            Console.WriteLine("Substract: " + su);

            Console.ReadKey();
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
