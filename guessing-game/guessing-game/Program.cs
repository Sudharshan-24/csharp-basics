using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Hello";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
            //}
            //if (outOfGuesses)
            //{
            //    Console.WriteLine("Sorry, You Lose :(");
            //}
            //else
            //{
            //    Console.WriteLine("Congrats! Your guess is Correct :)");
            //}

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            } while (guess != secretWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("Sorry, You Lose :(");
            }
            else
            {
                Console.WriteLine("Congrats! Your guess is Correct :)");
            }

            Console.ReadLine();
        }
    }
}
