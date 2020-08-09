using System;
using System.Linq;

namespace Libraries_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a 3 digit integer!");
            string num = Console.ReadLine();
            char[] chars = num.ToCharArray();
            int[] numArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numArray[i] = (int)Char.GetNumericValue(chars[i]);
            }
            Console.WriteLine("highest value is " + numArray.Max());
            Console.WriteLine("lowest value is " + numArray.Min());
        }
    }
}
