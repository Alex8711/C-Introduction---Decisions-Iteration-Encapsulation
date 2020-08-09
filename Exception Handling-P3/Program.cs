// Modify your program from question 3 in the “Iteration and Basic Validation” section in order to allow the user to enter 3 numbers and 3 associated words. Throw exceptions if duplicate words or numbers are used, handle them, and prompt again. Throw an exception if a number less than 2 is entered as a divisor. Allow the user to enter a start and end point to count between. Throw an exception if the end is less than the start, either number is less than or equal to 0, or if the span between the two numbers is greater than 100. Do not allow the user to enter nothing or whitespace as a word.
using System;
using System.Collections;

namespace Exception_Handling_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please input your first number");
            int num_1 = int.Parse(Console.ReadLine());
            while (num_1 < 2)
            {
                System.Console.WriteLine("Please input your first number, It should NOT be less than 2");
                num_1 = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Please input your second number");
            int num_2 = int.Parse(Console.ReadLine());
            while (num_2 < 2 || num_2 == num_1)
            {
                System.Console.WriteLine("Please input your second number, It should NOT be less than 2 and NOT duplicate");
                num_2 = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Please input your third number");
            int num_3 = int.Parse(Console.ReadLine());
            while (num_3 < 2 || num_3 == num_1 || num_3 == num_2)
            {
                System.Console.WriteLine("Please input your third number, It should NOT be less than 2 and NOT duplicate");
                num_3 = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Please input your first word");
            String num_1_replace = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(num_1_replace))
            {
                System.Console.WriteLine("Please input your first word,It should not be empty or ONLY whitespace");
                num_1_replace = Console.ReadLine();
            }
            System.Console.WriteLine("Please input your second word");
            String num_2_replace = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(num_2_replace) || num_2_replace.Equals(num_1_replace))
            {
                System.Console.WriteLine("Please input your second word,It should not be empty or ONLY whitespace. It should NOT duplicate");
                num_2_replace = Console.ReadLine();
            }
            System.Console.WriteLine("Please input your third word");
            String num_3_replace = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(num_3_replace) || num_3_replace.Equals(num_1_replace) || num_3_replace.Equals(num_2_replace))
            {
                System.Console.WriteLine("Please input your third word,It should not be empty or ONLY whitespace. It should NOT duplicate");
                num_3_replace = Console.ReadLine();
            }
            ArrayList list = new ArrayList();
            for (int i = 1; i < 101; i++)
            {
                if (i % num_1 == 0)
                {
                    System.Console.WriteLine(num_1_replace);
                    list.Add(num_1_replace);
                }
                else if (i % num_2 == 0)
                {
                    System.Console.WriteLine(num_2_replace);
                    list.Add(num_2_replace);
                }
                else if (i % num_3 == 0)
                {
                    System.Console.WriteLine(num_3_replace);
                    list.Add(num_3_replace);
                }
                else
                {
                    System.Console.WriteLine(i);
                    list.Add(i);
                }
            }
            System.Console.WriteLine("Please input the start to counter");
            int start = int.Parse(Console.ReadLine());
            while (start <= 0)
            {
                System.Console.WriteLine("Please input the start to counter,it should be greater than 0");
                start = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Please input the end to counter");
            int end = int.Parse(Console.ReadLine());
            while (end < start)
            {
                System.Console.WriteLine("Please input the end to counter,it should be greater than start");
                end = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = start - 1; i < end; i++)
            {
                if (list[i].GetType() == typeof(String))
                {
                    count++;
                }
            }
            System.Console.WriteLine("count is " + count);
            if (count >= 100)
            {
                System.Console.WriteLine("something wrong with your program ");
            }
            Console.ReadKey();
        }
    }
}
