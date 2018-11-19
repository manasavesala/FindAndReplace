using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplaceA.Models;


namespace FindAndReplaceA.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {

    [TestMethod]
    public void oneWord_Replace()
    {
      //Arrange
      string sentence = "my name is manasa";
      string word = "manasa";
      string wordReplace = "murali";

      Assert.AreEqual("my name is murali", FindAndReplace.AfterReplaced(sentence,word,wordReplace));

    }

    // [TestMethod]
    // public void getAnagrams_TwoAnagrams()
    // {
    //   //Arrange
    //   string word1 = "aaanms";
    //   string word2 = "aaasnm";
    //   string name = "manasa";
    //   List<string> newList = new List<string> { word1, word2 };

    //   //Act
    //   string[] result = Anagram.getAnagrams(name, newList.ToArray());
      
    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    //  }

     

    // [TestMethod]
    // public void IsWords_Array_Sorted()
    // {
    //   // Anagram newItem = new Anagram();
    //   string name = "manasa";
    //   Assert.AreEqual("aaamns", Anagram.InOrder(name));
    // }




  }

}
