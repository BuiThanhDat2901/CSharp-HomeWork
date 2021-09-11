using System;

namespace Lab1_ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter address: ");
            var address = Console.ReadLine();
            Console.WriteLine("Please enter phone: ");
            var phone = Console.ReadLine();
            Console.WriteLine("The information you just entered is: ");
            Console.WriteLine($"Name: {name}\nAddress: {address}\nPhone: {phone}");
        }
    }
}