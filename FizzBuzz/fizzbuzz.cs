
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("FizzBuzz up to what number?");
            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                if (i % 15 ==0)
                {
                    System.Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 ==0)
                {
                    System.Console.WriteLine("fizz");
                }
                else if (i % 5 ==0)
                {
                    System.Console.WriteLine("buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
