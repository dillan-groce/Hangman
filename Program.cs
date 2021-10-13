using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Project is to create a hangman console app game
            //console app to choose a random word (string) from an array of words
            //string[] words = {"word", "word", "word", "word"};
            //user to guess letters
            //if correct, display letter, if incorrect, display body

            ProgramUI ui = new ProgramUI();
            ui.DisplayHome();
            Console.ReadKey();
        }
    }
}
