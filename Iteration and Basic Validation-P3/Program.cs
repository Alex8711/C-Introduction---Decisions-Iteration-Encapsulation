// Write a program that will count from 1 to 100, 
// replacing every number divisible by 3 with “Fizz”, 
// every number divisible by 5 with “Buzz”, and every number 
// divisible by both 3 and 5 with “FizzBuzz”. Try to make it 
// as maintainable as possible, allowing more words and numbers to be easily added.
using System;

namespace Iteration_and_Basic_Validation_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1 = 3;
            int num_2 = 5;
            String num_1_replace = "Fizz";
            String num_2_replace = "Buzz";
            String replace = "FizzBuzz";
            for (int i = 1; i < 101; i++)
            {
                if (i % num_1 == 0 && i % num_2 == 0)
                {
                    System.Console.WriteLine(replace);
                }
                else if (i % num_1 == 0)
                {
                    System.Console.WriteLine(num_1_replace);
                }
                else if (i % num_2 == 0)
                {
                    System.Console.WriteLine(num_2_replace);
                }
                else
                { System.Console.WriteLine(i); }
            }
            Console.ReadKey();
        }
    }
}
