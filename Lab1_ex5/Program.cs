using System;

namespace Lab1_ex5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine($"{i}! = {Factorials(i)}");
            }
        }

        static double Factorials(int a)
        {
            if (a <= 1)
            {
                return 1;
            }
            return a * Factorials(a - 1);
        }
    }
}