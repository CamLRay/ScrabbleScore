using System.Collections.Generic;
using System.Linq;

namespace ScrabbleScore
{
  public class Scrabble 
  {
    public char[] Word { get; set; }

    private static Dictionary<string, int> letterDict = new Dictionary<string, int>() {{"aeioulnrst", 1}, {"dg", 2}, {"bcmp", 3}, {"fhvwy", 4}, {"k", 5}, {"jx", 8}, {"qz", 10}};
    public Scrabble(string word)
    {
      Word = word.ToLower().ToCharArray(); 
    }
  
    public int GetScoreDictionary()
    {
      int total = 0;
      foreach (KeyValuePair<string, int> letterGroup in letterDict)
      {
        foreach (char letter in Word)
        {
          if(letterGroup.Key.Contains(letter))
          {
           total += letterDict[letterGroup.Key];
          }
        }
      }
      return total;
    }
  }
}