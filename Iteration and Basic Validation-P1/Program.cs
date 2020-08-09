// Write a program that will prompt the user for an integer, 
// and continue prompting until an integer between 1 and 10 (inclusive) 
// is entered. Use a while loop.
using System;

namespace Iteration_and_Basic_Validation_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer");
            int num = int.Parse(Console.ReadLine());
            while (num > 10 || num < 1)
            {
                Console.WriteLine("please enter an integer");
                num = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
