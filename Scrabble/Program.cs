using System;
using ScrabbleScore;

public class Program 
{
  static void Main()
  {
    Console.WriteLine("Enter a Word");
    Scrabble userWord = new Scrabble(Console.ReadLine());
    int score = userWord.GetScoreDictionary();
    Console.WriteLine("Your Score for " + string.Join("", userWord.Word) + " is " + score);
  }
}
