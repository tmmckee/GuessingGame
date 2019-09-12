using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //time to play a game

            Guess guess = new Guess();
            guess.Range = 1001;
            guess.Range = 1000;
            int[] array = guess.CreateArray(guess.Range);
            int randomNumber = guess.CreateRandomNumber(array);
            guess.GuessToWin(randomNumber, guess.Range);

            //time for the computer to play
            ComputerGuess computer =new ComputerGuess();
            int max = computer.GetMax();
            int number = computer.GetNumber();
            computer.ComputerGuessesToWin(number, 1, max);

        }
    }
}
