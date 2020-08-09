// Write a program that will take in a 4 digit integer 
// and calculate the sum of its digits without 
// ever converting the integer to a string.
using System;

namespace Procedural_Programming_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a 4 digit integer!");
            string num = Console.ReadLine();
            char[] chars = num.ToCharArray();
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (int)Char.GetNumericValue(chars[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
