using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Guess
    {
        private int range;
        public int Range
        {
            get { return range; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException($"{value} should be between 0 and 1000.");
                }
                else { range = value; }

            }
        }

      

        public int CreateRandomNumber(int[] array)
        {
            Random r = new Random();
            int randNum = r.Next(0, array.Length);
            return randNum;
        }

        public int[] CreateArray(int numberOfElements)
        {
            int[] array= new int[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = i+1;
            }
            return array;
        }

        public void PrintArray(int[] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }



        public void GuessToWin(int randomNumber,  int lastNumber)
        {
            bool win = false;
            do
            {
                Console.WriteLine($"Guess a number in-between 0 and {lastNumber}!");
                string choice = Console.ReadLine();
                int numChoice = int.Parse(choice);

                if (numChoice>randomNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"{numChoice} was too high!");
                }
                else if (numChoice<randomNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"{numChoice} was too low!");
                }
                else if (numChoice==randomNumber)
                {
                    Console.Clear();
                    Console.WriteLine($"Congratulations! {numChoice} was the correct answer!");
                    win = true;
                }
            } while (win == false);
        }

        
    }
}
