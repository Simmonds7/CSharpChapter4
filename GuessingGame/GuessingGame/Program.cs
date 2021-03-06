﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGame();
        }
        static void DisplayGame()
        {
            int guess;
            string guessString;
            int min = 1;
            int max = 11;
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);
            do
            {
                Write("Welcome to the Random Number Guessing Game, R.N.G.G. Choose a number between 1 and 10.");
                guessString = ReadLine();
                guess = Convert.ToInt32(guessString);

                if (guess < max && guess >= min)
                {
                    if (randomNumber == guess)
                    {
                        result = "You have guessed correctly. The random number was " + randomNumber;
                    }
                    else if (guess > randomNumber)
                    {
                        result = "Your guess was incorrect. Try going lower.";
                    }
                    else if (guess < randomNumber)
                    {
                        result = "Your guess was incorrect. Try going higher.";
                    }
                }
                else
                    result = "Error. Number guessed doesn't fit the range.";
                DisplayString(result);
            } while (guess != randomNumber);
        }
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}
