using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class ProgramUI
    {
        private readonly Words_Repo _wordsRepo = new Words_Repo();

        public void Display()
        {
            DisplayHome();
        }
        public void DisplayHome()
        {
            {
                Console.Clear();
                Console.WriteLine("Welcome to Hangman!\n" +
                    "\n" +
                    "Please select your difficulty level:\n" +
                    "1. Easy\n" +
                    "2. Medium\n" +
                    "3. Hard\n" +
                    "4. Exit\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "____________________\n" +
                    "|          }\n" +
                    "|          O\n" +
                    "|          |\n" +
                    "|         /|\\\n" +
                    "|          |\n" +
                    "|         / \\\n" +
                    "|\n" +
                    "|\n" +
                    "|___________________\n");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Play easy level
                        Console.Clear();
                        PlayEasyLevel();
                        break;
                    case "2":
                        //Play medium level
                        PlayMediumLevel();
                        break;
                    case "3":
                        //Play hard level
                        PlayHardLevel();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid response.");
                        break;
                }
            }

        }
        public void PlayEasyLevel()
        {
            //ask the user to enter a guess and convert from string to char array
            //display how many characters the random word chosen has
            //allow 7 guess attempts plus the number of characters in the word
            Words_Repo easyDifficulty = new Words_Repo();
            string chosenWord = easyDifficulty.GenerateWord();
            char[] guess = new char[chosenWord.Length];

            Console.WriteLine("Please enter your guess.");
            Console.WriteLine("The word you are trying to guess has {0} characters.", chosenWord.Length);
            //
            for (int variableName = 0; variableName < chosenWord.Length; variableName++)
                guess[variableName] = '_';

            int guessAttempts = 7 + chosenWord.Length;

            while (guessAttempts > 0)
            {
                char playerGuess = char.Parse(Console.ReadLine());

                for (int anotherVariable = 0; anotherVariable < chosenWord.Length; anotherVariable++)
                {
                    if (playerGuess == chosenWord[anotherVariable])
                    {
                        guess[anotherVariable] = playerGuess;
                    }
                    //else
                    //{
                    //    guessAttempts--;
                    //}
                }
                //tell the player how many guesses they have left.
                Console.WriteLine(guess);
                Console.WriteLine("You have {0} guesses left.", guessAttempts);
            }
        }
        public void PlayMediumLevel()
        {
            Words_Repo mediumDifficulty = new Words_Repo();
            Console.Clear();
            Console.WriteLine("You have chosen to play the medium level!\n" +
                "Hint: The word is a type of brass instrument.\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "____________________\n" +
                    "|          }\n" +
                    "|          \n" +
                    "|          \n" +
                    "|         \n" +
                    "|          \n" +
                    "|          \n" +
                    "|\n" +
                    "|\n" +
                    "|___________________\n");
        }
        public void PlayHardLevel()
        {
            Words_Repo hardDifficulty = new Words_Repo();
            Console.Clear();
            Console.WriteLine("You have chosen to play the hard level!\n" +
                "*evil laughter* MUUUAHAHAHAHAHAHA\n" +
                "Hint: This word was coined in the 1964 musical 'Mary Poppins'" +
                                                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "\n" +
                    "____________________\n" +
                    "|          }\n" +
                    "|          \n" +
                    "|          \n" +
                    "|         \n" +
                    "|          \n" +
                    "|         \n" +
                    "|\n" +
                    "|\n" +
                    "|___________________\n");
        }
    }
}
