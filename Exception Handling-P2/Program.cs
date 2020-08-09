// Modify your program from question 4 in the “Expressions and Decisions” 
// section in order to allow the user to enter 0 as a divisor and not have 
// the program crash. Prompt them for a new divisor if they do.
using System;

namespace Exception_Handling_P2
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
                while (num_2 == 0)
                {
                    Console.WriteLine("please input a valid divisor");
                    num_2 = int.Parse(Console.ReadLine());
                }
                double res = num_1 / num_2;
                System.Console.WriteLine("{0} {1} {2} = {3}", num_1, operatorInput, num_2, res);
            }
        }
    }
}
