// Write a program that will prompt for up to 20 marks, 
// until the user enters all 20 or enters -1. 
// Ensure that the user enters at least 1 mark. 
// When done, output the average, highest and lowest marks 
// from the “class”. Once finished, ask if they would like to 
// start again. If they enter any integer that is not between 
// -1 and 100 inclusive, prompt again and disregard the last input.
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Iteration_and_Basic_Validation_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> markList = new List<int>();

            Console.WriteLine("please input a mark, it should be between 0 and 100 inclusive.");
            int inputMark = int.Parse(Console.ReadLine());
            while (inputMark < 0 || inputMark > 100)
            {
                Console.WriteLine("please input a Valid mark, it should be between 0 and 100 inclusive.");
                inputMark = int.Parse(Console.ReadLine());
            }
            markList.Add(inputMark);

            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine("please input a mark, it should be between 0 and 100 inclusive. If you want to stop,you can enter -1");
                inputMark = int.Parse(Console.ReadLine());
                while (inputMark > 100 || inputMark < -1)
                {
                    Console.WriteLine("please input a mark, it should be between 0 and 100 inclusive. If you want to stop,you can enter -1");
                    inputMark = int.Parse(Console.ReadLine());
                }
                if (inputMark == -1)
                {
                    break;
                }
                markList.Add(inputMark);
            }
            int[] array = markList.ToArray();
            System.Console.WriteLine("Highest value {0}", array.Max());
            System.Console.WriteLine("Lowest value {0}", array.Min());
            System.Console.WriteLine("Average value {0}", array.Average());
            System.Console.WriteLine("Do you like to start again?");
            Console.ReadKey();
        }
    }
}
