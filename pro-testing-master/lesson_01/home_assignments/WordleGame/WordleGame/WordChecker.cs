using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame
{
    class WordChecker
    {
        public string CheckWord(string wordToGuess, string playerGuess)
        {
            char[] arrayToCheck = wordToGuess.ToCharArray();
            char[] playerGuessToCheck = playerGuess.ToCharArray();

            var correctLetters = arrayToCheck.Where(l => playerGuessToCheck.Contains(l)).ToList();


            return string.Join("", correctLetters);
        }
    }
}
