// Write a program that will generate a random password that 
// is 5 characters long, consisting of uppercase letters 
// (look up how to convert from an integer to a character, and 
// append a character to a string).
using System;
using System.Linq;
namespace Libraries_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Random random = new Random();
            string res = RandomString(5, random);
            System.Console.WriteLine(res);
            Console.ReadKey();
        }
        public static string RandomString(int length, Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
