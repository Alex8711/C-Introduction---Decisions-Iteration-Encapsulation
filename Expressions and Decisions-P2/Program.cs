// Write a program that will take in an integer from the user and 
// display whether it is odd or even.

using System;

namespace Expressions_and_Decisions_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer");
            int res = int.Parse(Console.ReadLine());
            if (res % 2 == 0)
            {
                System.Console.WriteLine("it is even");
            }
            else
            {
                System.Console.WriteLine("it is odd");
            }
            Console.ReadKey();
        }
    }
}
