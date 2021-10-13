using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangman;

namespace ConsoleApp1
{
    public class Words_Repo //
    {
        public string EasyDifficulty;
        public string MediumDifficulty;
        public string HardDifficulty;
        public Words_Repo() { }
        public Words_Repo(string easyDifficulty, string mediumDifficulty, string hardDifficulty)
        {
            EasyDifficulty = easyDifficulty;
            MediumDifficulty = mediumDifficulty;
            HardDifficulty = hardDifficulty;
        }
        private string[] listwords = new string[10];
        public string GenerateWord()
        {
            //this method generates a random word from the array of strings list words. [10] indicates only 10 elements can be used in the index
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            int idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            return mysteryWord;
        }
        }
        
    }

