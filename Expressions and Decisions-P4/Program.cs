// Write a program that will take in an operator (such as + or *) and 
// two operands (as ints), and output the result. 
// Ensure division produces accurate results.
using System;

namespace Expressions_and_Decisions_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input the first int");
            double num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please input one operator from '+,-,/,*'");
            String operatorInput = Console.ReadLine();
            Console.WriteLine("please input the second int");
            double num_2 = int.Parse(Console.ReadLine());
            if (operatorInput.Equals("+"))
            {
                double res = num_1 + num_2;
                System.Console.WriteLine("{0} {1} {2} = {3}", num_1, operatorInput, num_2, res);
            }
            else if (operatorInput.Equals("-"))
            {
                double res = num_1 - num_2;
                System.Console.WriteLine("{0} {1} {2} = {3}", num_1, operatorInput, num_2, res);
            }
            else if (operatorInput.Equals("*"))
            {
                double res = num_1 * num_2;
                System.Console.WriteLine("{0} {1} {2} = {3}", num_1, operatorInput, num_2, res);
            }
            else
            {
                double res = num_1 / num_2;
                System.Console.WriteLine("{0} {1} {2} = {3}", num_1, operatorInput, num_2, res);
            }
        }
    }
}
