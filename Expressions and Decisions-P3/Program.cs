// Write a program that will determine whether a number entered by the user is a 
// perfect square of a whole number or not.

using System;

namespace Expressions_and_Decisions_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a number");
            int num = int.Parse(Console.ReadLine());
            double res = Math.Sqrt(num);
            int intRes = (int)res;
            if (res == intRes)
            {
                System.Console.WriteLine("the number is a perfect square of a whole number");
            }
            else
            {
                System.Console.WriteLine("the number is NOT a perfect square of a whole number");
            }
            Console.ReadKey();
        }
    }
}
