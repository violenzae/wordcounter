using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Word
  {
    public static int Counter(string word, string sample)
    {
      int count = 0;

      string[] sampleArray = sample.ToLower().Split(" ");

      foreach(var item in sampleArray)
      {
        if (item == word.ToLower())
        {
          count++;
        }
      }
      return count;
    }
  }
}