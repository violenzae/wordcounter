using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Word
  {
    public static int Counter(string word, string sample)
    {
      int count = 0;
      char[] punctuation = { ' ', ',' , '.', ':', ';', '[', ']', '(', ')'};

      string[] sampleArray = sample.ToLower().Split(punctuation);

      foreach(var item in sampleArray)
      {
        string[] sampleLetterArray = item.Split();
        if (item == word.ToLower())
        {
          count++;
        }
      }
      return count;
    }
  }
}