using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Counter_ReturnIntOfOccurences_int()
    {
      string word = "a";
      string sample = "a A a";

      Assert.AreEqual(3, Word.Counter(word, sample));
    }
    [TestMethod]
    public void Counter_ReturnOccurencesNoSpace_int()
    {
      string word = "a";
      string sample = "aaa a";

      Assert.AreEqual(1, Word.Counter(word, sample));
    }
    [TestMethod]
    public void Counter_ReturnOccurencesPunctuation_int()
    {
      string word = "sight";
      string sample = "It was love at first sight, at last sight, at ever and ever sight.";

      Assert.AreEqual(3, Word.Counter(word,sample));
    }
    [TestMethod]
    public void EndState_ReturnMessageNoOccurence_string()
    {
    int count = 0;
    string message ="Sorry, there were no occurences. Check your spelling, or try another combination!";

    Assert.AreEqual(message, Word.EndState(count));
    }
        [TestMethod]
    public void EndState_ReturnMessageXOccurence_string()
    {
    int count = 7;
    string message = "This word appeared 7 times.";

    Assert.AreEqual(message, Word.EndState(count));
    }
  }
}