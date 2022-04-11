using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cards do you have: ");

            int number = int.Parse(Console.ReadLine());
            string value;
            int sum = 0;

            Console.WriteLine($"So you have {number} cards");

            for (int i = 1; i <= number; i++)
            {
                Console.Write($"Enter your {i} card: ");
                value = Console.ReadLine();
                switch(value)
                {
                    case "j":
                        sum += 10;
                        break;

                    case "q":
                        sum += 10;
                        break;

                    case "k":
                        sum += 10;
                        break;

                    case "a":
                        sum += 10;
                        break;

                    default:
                        sum += int.Parse(value);
                        break;
                }
            }

            if(sum <= 21)
            {
                Console.WriteLine($"Your score is: {sum}");
            }
            else
            {
                Console.WriteLine($"Your score is: {sum} you have lost :(");
            }
 

        }
    }
}
