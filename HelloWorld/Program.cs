using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("Hello Application");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Say Goodbye");
                Console.WriteLine("0. Exit");
                Console.WriteLine("-----------------");
                Console.WriteLine("Please enter your choice (0-2) :");
                var choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name:");
                        var name = Console.ReadLine();
                        Console.WriteLine($"Hello {name}");
                        break;
                    case 2:
                        Console.WriteLine("Nice to meet you");
                        break;
                    case 0:
                        Console.WriteLine("Bye Bye");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                if (choice == 0)
                {
                    break;
                }
            }
        }
    }
}