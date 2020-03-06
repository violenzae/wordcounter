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
  }
}