using System;

namespace quiz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num_2 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num_3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Result: {(num_1 + num_2) * num_3}");
            Console.WriteLine($"Result: {(num_1 * num_2) + (num_2 * num_3)}");
        }
    }
}