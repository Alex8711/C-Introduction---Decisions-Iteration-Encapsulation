// Write a program that will take in a 3 character month code (case insensitive) 
// and output the full name of that month and the number of days in that month, 
// using a switch. Only prompt for the year if the code for February is entered.
using System;

namespace Expressions_and_Decisions_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a 3 character month code(case insensitive)");
            string year = DateTime.Now.Year.ToString();
            string monthCode = Console.ReadLine();

            string monthCodeLowerCase = monthCode.ToLower();
            switch (monthCodeLowerCase)
            {
                case "jan":
                    System.Console.WriteLine("January,31 days");
                    break;
                case "feb":
                    System.Console.WriteLine(year);
                    break;
                case "mar":
                    System.Console.WriteLine("March,31 days");
                    break;
                case "apr":
                    System.Console.WriteLine("April,30 days");
                    break;
                case "may":
                    System.Console.WriteLine("May,31 days");
                    break;
                case "jun":
                    System.Console.WriteLine("June,30 days");
                    break;
                case "jul":
                    System.Console.WriteLine("July,31 days");
                    break;
                case "aug":
                    System.Console.WriteLine("August,31 days");
                    break;
                case "sep":
                    System.Console.WriteLine("September,30 days");
                    break;
                case "oct":
                    System.Console.WriteLine("October,31 days");
                    break;
                case "nov":
                    System.Console.WriteLine("November,30 days");
                    break;
                case "dec":
                    System.Console.WriteLine("December,31 days");
                    break;
            }

            Console.ReadKey();
        }
    }
}
