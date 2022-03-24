using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WordleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] listOfWordsToGuess = { "valid", "solid", "class"  };
            //Random r = new Random();
            //string wordToGues = listOfWordsToGuess[r.Next(0, listOfWordsToGuess.Length - 1)];

            //Console.WriteLine("Enter word with length 5 letters");

            
            //bool isItWright = false;

            //do
            //{
            //    string playerGuess = Console.ReadLine();
            //    if (playerGuess == wordToGues)
            //    {
            //        isItWright = true;
            //        Console.WriteLine("You win");
            //    }
            //    Console.WriteLine("Try Again");

            //} while (!isItWright);
            WordChecker a = new WordChecker();
            Word wordToGuess = new Word();

            var playerGess = "solid";

            Console.WriteLine(a.CheckWord(wordToGuess.word, playerGess));
        }
    }
}
