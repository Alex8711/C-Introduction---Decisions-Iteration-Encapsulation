// Write a program that will say “Hello”, and wait for 
// input from the user. It will continue saying “Hello” 
// until the user enters “stop” (case insensitive). Use a do-while loop.
using System;

namespace Iteration_and_Basic_Validation_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string userInput = Console.ReadLine().ToLower();
            do
            {
                if (userInput.Equals("stop"))
                {
                    break;
                }
                System.Console.WriteLine("Hello");
                userInput = Console.ReadLine().ToLower();
            } while (!userInput.Equals("stop"));
            Console.ReadKey();
        }
    }
}
