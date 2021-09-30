using System;

namespace Lab3_Part4_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee("Bui", "Dat", "Hung Yen", 20, 100000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Bonus: " + employee.Bonus(0.2));
        }
    }
}