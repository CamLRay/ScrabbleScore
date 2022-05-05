using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore;

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
  }
}