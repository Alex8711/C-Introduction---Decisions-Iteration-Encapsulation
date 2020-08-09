// Write a program that will take in two sides of 
// a right triangle and determine the length of 
// the hypotenuse to 2 decimal places, using the pythagorean theorem.

using System;

namespace Libraries_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input one side(integer) of the right triangle");
            int oneSide = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the other side(integer) of the right triangle");
            int otherSide = int.Parse(Console.ReadLine());
            double res = Math.Sqrt(oneSide * oneSide + otherSide * otherSide);
            System.Console.WriteLine(Math.Round(res, 2));
        }
    }
}
