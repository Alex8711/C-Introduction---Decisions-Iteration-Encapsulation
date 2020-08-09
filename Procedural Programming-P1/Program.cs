// Write a program that prompts the user for a number (as an int) 
// and outputs the cube of that number (raised to the third power).

using System;

namespace Procedural_Programming_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter an integer!");
            String input = Console.ReadLine();
            int num = int.Parse(input);
            int res = num * num * num;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
