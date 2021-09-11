using System;

namespace Lab1_ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}