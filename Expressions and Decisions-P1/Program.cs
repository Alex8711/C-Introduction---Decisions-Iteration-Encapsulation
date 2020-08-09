// Write a program that will generate a random number between 1 and 10, 
// prompt two users for a guess, and output the winner (closest to the number). 
// If both guesses are equidistant from the target or 
// both players guess the same number, it is a draw.

using System;

namespace Expressions_and_Decisions_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            Console.WriteLine("Player_1, please guess the number!");
            int guess_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Player_2, please guess the number!");
            int guess_2 = int.Parse(Console.ReadLine());
            if (guess_1 == guess_2)
            {
                System.Console.WriteLine("It is a draw, both players guess the same number, the randomnumber is " + randomNumber);
            }
            else if (Math.Abs(guess_1 - randomNumber) == Math.Abs(guess_2 - randomNumber))
            {
                System.Console.WriteLine("It is a draw,both guesses are equidistant from the target, the randomnumber is " + randomNumber);
            }
            else if (Math.Abs(guess_1 - randomNumber) < Math.Abs(guess_2 - randomNumber))
            {
                System.Console.WriteLine("winner is player_1, the randomnumber is " + randomNumber);
            }
            else
            {
                System.Console.WriteLine("winner is player_2, the randomnumber is " + randomNumber);
            }
            Console.ReadKey();
        }
    }
}
