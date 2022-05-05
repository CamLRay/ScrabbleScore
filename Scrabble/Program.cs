using System;
using ScrabbleScore;
using NumberToWords;

public class Program 
{
  static void Main()
  {
    Console.WriteLine("(1) Number (2)ScrabbleScore");
    string userInput = Console.ReadLine();
    if(int.Parse(userInput) == 1)
    {
      Console.WriteLine("Enter a number");
      long userNum= long.Parse(Console.ReadLine());
      Console.WriteLine("You entered "+Number.LargeNumberTranslator(userNum));
    }
    else if(int.Parse(userInput) == 2)
    {
      Console.WriteLine("Enter a Word");
      Scrabble userWord = new Scrabble(Console.ReadLine());
      int score = userWord.GetScoreDictionary();
      Console.WriteLine("Your Score for " + string.Join("", userWord.Word) + " is " + score);
    }
    else 
    {
      Console.WriteLine("Invalid Input");
      Main();
    }
  }
}
