// Modify your program from question 1 in the “Iteration and Basic Validation” 
// section in order to allow the user to enter non-numeric data without the program 
// crashing. Throw an exception if they enter a number that is not 
// between 1 and 10 (inclusive). Output the exception message as part of your error.
using System;

namespace Exception_Handling_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter an integer");
            // int num = int.Parse(Console.ReadLine());
            String input = Console.ReadLine();
            bool numOrNot = Int32.TryParse(input, out int tempNumber);

            if (numOrNot)
            {
                int num = int.Parse(input);
                try
                {
                    while (num > 10 || num < 1)
                    {
                        throw new Exception("Expected a value between 1 and 10");
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

            }
            else
            {
                System.Console.WriteLine("It is not an integer");
            }

            Console.ReadKey();
        }
    }
}
