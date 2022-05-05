using System;
using System.Collections.Generic;
using System.Linq;
namespace NumberToWords
{
  public class Number{
    private static Dictionary<long, string> _singleDigitDictionary = new Dictionary<long, string>() {
      {1, "one"}, 
      {2, "two"}, 
      {3, "three"}, 
      {4, "four"}, 
      {5, "five"}, 
      {6, "six"}, 
      {7, "seven"}, 
      {8, "eight"}, 
      {9, "nine"}, 
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}}; 
    private static Dictionary<long, string> _TensDigitDictionary = new Dictionary<long, string>() {
      {1, "ten"},
      {2, "twenty"}, 
      {3, "thirty"},
      {4, "fourty"},
      {5, "fifty"},
      {6, "sixty"},
      {7, "seventy"},
      {8, "eighty"},
      {9, "ninety"}};

    private static Dictionary<long, string> _FoldDigitDictionary = new Dictionary<long, string>() {
      {100, "hundred"},
      {1000, "thousand"}, 
      {1000000, "million"},
      {1000000000, "billion"},
      {1000000000000, "trillion"},
      {1000000000000000,"quadrillion"}};
      
      // 1,100,101 one million one hundred thousand one hundred one

// 1121
    public static string NumberTranslator(long number)
    {
      string numberString = "";
      if(number > 0)
      {
        if(number < 20)
        {
          numberString += _singleDigitDictionary[number];
        }
        else if (number < 100)
        {
          numberString += _TensDigitDictionary[number/10];
          if(number % 10 > 0)
          {
            numberString += "-" + _singleDigitDictionary[number % 10];
          }
        }
      }
      return numberString;
    }
// 1001
    public static string LargeNumberTranslator(long number)
    {
      List<string> stringList = new List<string>() {};
      if(number == 0)
      {
        return "zero";
      }
      else if (number < 100)
      {
        return NumberTranslator(number);
      }
      for (int i = _FoldDigitDictionary.Count -1; i >= 0; i--)
      {
        long dictKey = _FoldDigitDictionary.ElementAt(i).Key;
        if(number >= dictKey)
        {
          if(number/(dictKey) >= 100){
            long tempNum = number/(dictKey);
            stringList.Add(NumberTranslator(tempNum/100) + " hundred");
            stringList.Add(NumberTranslator(tempNum%100));
          }
          stringList.Add(NumberTranslator(number/dictKey));
          stringList.Add(_FoldDigitDictionary.ElementAt(i).Value);
          stringList.Add(NumberTranslator(number%(dictKey)));
          number%=(dictKey);
        }
      }
  
      string numberString = "";
      foreach(string word in stringList)
      {
        if(word != "")
        {
          numberString += word + " ";
        }
      }
      return numberString.Trim();
    }

  }
}