// Write a program that will take in a total dollar value (as a double) 
// and a number of diners (as an int) and calculate the amount of 
// the bill that each diner should pay (equal split).
using System;

namespace Procedural_Programming_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input total value");
            double total = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input the number of diners");
            int num = int.Parse(Console.ReadLine());
            double pay = total / num;
            Console.WriteLine("Each diner should pay $" + pay);
        }
    }
}
