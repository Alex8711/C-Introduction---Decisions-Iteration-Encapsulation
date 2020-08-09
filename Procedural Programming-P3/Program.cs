// Write a program that will take in a user’s age and calculate their birth year 
// (assuming this year’s birthday has passed).
using System;

namespace Procedural_Programming_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your age!");
            int age = int.Parse(Console.ReadLine());
            int currentYear = int.Parse(DateTime.Now.Year.ToString());
            int birthYear = currentYear - age;
            Console.WriteLine("Your birthYear is " + birthYear);
        }
    }
}
