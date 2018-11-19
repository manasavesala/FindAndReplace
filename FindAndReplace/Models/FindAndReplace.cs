using System;
using System.Linq;
using System.Collections.Generic;

namespace FindAndReplaceA.Models
{
  public static class FindAndReplace
  {

    public static string AfterReplaced(string sentence, string wordToBeReplace, string wordToBeReplacedWith)
    {
      string[] sentenceWords = sentence.Split();

      for(int i = 0; i < sentenceWords.Length; i++)
      {
        if(wordToBeReplace == sentenceWords[i])
        {
          sentenceWords[i]=wordToBeReplacedWith;
        }
      }

      // List<string> --> string[]
      // List<int> --> int[]
      string sentence1 = string.Join(" ",sentenceWords);
      return sentence1;
    }


    public static void Main()
    {
      Console.WriteLine("Please enter a Sentence:");
      string userInputwordSentence = Console.ReadLine();
      Console.WriteLine("Please enter a word to be replace:");
      string userInputwordToBeReplace = Console.ReadLine();
      Console.WriteLine("Please enter a word to be replaced with:");
      string userInputwordToBeReplacedWith = Console.ReadLine();

      Console.WriteLine(AfterReplaced(userInputwordSentence,userInputwordToBeReplace,userInputwordToBeReplacedWith));
    }

  }
}
