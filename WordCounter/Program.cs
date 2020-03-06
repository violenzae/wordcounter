
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter
{
  public class Program
  {
    static void Main()
    {
      
      string banner = @"
      __       __)           )   ___                       
      (, )  |  /          /) (__/_____)                     
        | /| /  _____  _(/    /       ___   __  _/_  _  __ 
        |/ |/  (_)/ (_(_(_   /       (_)(_(_/ (_(___(/_/ (_
        /  |                (______)                       
                                                            
      ";

      Console.Write(banner);

      Console.WriteLine("This is an application that will search an inputted string for instances of a an inputted word. Please enter text to be combed for a word:");
      
      string sample = Console.ReadLine();

      Console.WriteLine("Please enter the word that you would like to count instances for within the above text:");
      
      string word = Console.ReadLine();

      int count = Word.Counter(word, sample);
      
      Console.WriteLine(Word.EndState(count));

      Console.WriteLine("Would you like to start over? Press 'y' to start a new search, or any other key to exit.");
      
      string response = Console.ReadLine();
      
      if(response == "y")
      {
        Main();
      }
    }
  }
}