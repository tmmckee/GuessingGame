using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class ComputerGuess
    {
        public int GetMax()
        {
            Console.WriteLine("Please enter how high of a range you'd like to " +
                              "choose a number from for the computer!");
            int max = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            return max;
        }

        public int GetNumber()
        {
            Console.WriteLine("Please enter what the number is that you would" +
                              " like the computer to try and guess!");
            int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            return number;
        }

        public void ComputerGuessesToWin(int numberToGuess, int min, int max)
        {
            Random random = new Random();
            bool win = false;
            try
            {
                do
                {
                    int guess = random.Next(min, max);
                    Console.WriteLine($"Beep bop, {guess} is my guess!");

                    if (guess > numberToGuess)
                    {
                        Console.WriteLine($"Number is {numberToGuess}... Tell the computer it guessed too high!");
                        Console.ReadLine();
                        max = guess-1;

                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine(
                            $"Number is {numberToGuess}... Break the bad news to the bot that it is too low!");
                        Console.ReadLine();
                        min = guess+1;

                    }
                    else if (guess == numberToGuess)
                    {
                        Console.WriteLine($"{guess} is the correct answer! Congratulate the computer!!");
                        Console.ReadLine();
                        win = true;
                    }
                } while (win == false);

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Try again.");
                ComputerGuessesToWin(numberToGuess,min,max);
            }
        }
    }
}
