// Write a program that will take in a number of fence posts 
// and determine how many buckets of paint will be required to 
// paint the fence posts. One bucket paints 4 fence posts.
using System;

namespace Libraries_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of fence post(s)");
            int numOfPosts = int.Parse(Console.ReadLine());
            int numOfBuckets;
            if (numOfPosts % 4 == 0)
            {
                numOfBuckets = numOfPosts / 4;
            }
            else
            {
                numOfBuckets = numOfPosts / 4 + 1;
            }
            System.Console.WriteLine("we need {0} buckets of paint", numOfBuckets);
        }
    }
}
