using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish a secret word variable
            string secretWord = "giraffe";

            //establish a guess variable
            string guess = "";

            int guessCount = 5;

            //while the guess is not equal to the secret word, keep asking for a guess and decrement the guess count
            while (guess !=secretWord && guessCount > 0) {
                Console.Write("You have " + guessCount + " guesses left, " + "Enter guess: ");
                guess = Console.ReadLine();
                guessCount--;
            }
            
            //if the guess count is 0, the user loses, otherwise they win
            if (guessCount == 0) {
                Console.WriteLine("You are out of guesses! You lose! Womp Womp!");
                Console.WriteLine("The secret word was " + secretWord);
            } else {
                Console.WriteLine("You win! You had " + guessCount + " guesses left!");
            }

            Console.ReadLine();
        }
    }
}
