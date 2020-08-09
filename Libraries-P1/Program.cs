// Write a program that will take in a string, convert it to uppercase, 
// and output it.

using System;

namespace Libraries_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string!");
            String input = Console.ReadLine();
            String res = input.ToUpper();
            System.Console.WriteLine(res);
        }
    }
}
