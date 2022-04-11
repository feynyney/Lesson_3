using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your value: ");
            int N = int.Parse(Console.ReadLine());
            int i = 2;
            bool flag = true;

            if(N > 1)
            {
                while (i < N - 1)
                {
                    if (N % i == 0)
                    {
                        flag = false;
                    }
                    i++;
                }

                if (flag)
                {
                    Console.WriteLine("Number is simple!");
                }

                else
                {
                    Console.WriteLine("Number is NOT simple");
                }
            }

            else
            {
                Console.WriteLine("Number is NOT simple");
            }
            
     
        }
    }
}
