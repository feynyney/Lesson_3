using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} can be divided by 2");
            }

            else
            {
                Console.WriteLine($"{num} cannot be divided by 2");
            }

            Console.ReadKey();
        }
    }
}
