using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore;
using NumberToWords;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void Scrabble_CreatesScrabbleObject_Object()
    {
      Scrabble testWord = new Scrabble("Word");
      Assert.IsInstanceOfType(testWord.Word, typeof(Array));
    }
    [TestMethod]
    public void GetScore_SinglePointLetterScore_2()
    {
      Scrabble testWord = new Scrabble("Supercalifragilisticexpialidocious");
      Assert.AreEqual(56, testWord.GetScoreDictionary());
    }
    [TestMethod]
    public void NumberTranslator_TranslatesSignleNumberToWord_Srting()
    {
      Assert.AreEqual("two", Number.NumberTranslator(2));
    }
    [TestMethod]
    public void NumberTranslator_TranslatesTwoDigitNumberToWord_String()
    {
      Assert.AreEqual("twenty-two", Number.NumberTranslator(22));
    }
     [TestMethod]
    public void LargeNumberTranslator_TranslatesThreeDigitNumberToWord_String()
    {
      Assert.AreEqual("one hundred twenty-one", Number.LargeNumberTranslator(121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesFourDigitNumberToWord_String()
    {
      Assert.AreEqual("one thousand one hundred twenty-one", Number.LargeNumberTranslator(1121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesFiveDigitNumberToWord_String()
    {
      Assert.AreEqual("ten thousand one hundred twenty-one", Number.LargeNumberTranslator(10121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesSixDigitNumberToWord_String()
    {
      Assert.AreEqual("one hundred twenty-three thousand one hundred twenty-one", Number.LargeNumberTranslator(123121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesSevenDigitNumberToWord_String()
    {
      Assert.AreEqual("one million one hundred twenty-one", Number.LargeNumberTranslator(1000121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesEightDigitNumberToWord_String()
    {
      Assert.AreEqual("ten million one hundred twenty-one", Number.LargeNumberTranslator(10000121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesNineDigitNumberToWord_String()
    {
      Assert.AreEqual("one hundred million one hundred twenty-one", Number.LargeNumberTranslator(100000121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesTenDigitNumberToWord_String()
    {
      Assert.AreEqual("one billion one hundred twenty-one", Number.LargeNumberTranslator(1000000121));
    }
    [TestMethod]
    public void LargeNumberTranslator_TranslatesThirteenDigitNumberToWord_String()
    {
      Assert.AreEqual("one trillion one hundred twenty-one", Number.LargeNumberTranslator(1000000000121));
    }

  }
}