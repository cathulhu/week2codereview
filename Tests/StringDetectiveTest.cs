using System;
using System.Collections.Generic;
using Xunit;

namespace StringDetectiveNamespace
{
  public class StringDetectiveTest
  {
    [Fact]
    public void Search_Matchingwholestring_true()
    {
      StringDetective newStringDetective = new StringDetective("cat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal(-42, newStringDetective.Search());
    }
    [Fact]
    public void Search_partialdoesntclaimfullmatch_false()
    {
      StringDetective newStringDetective = new StringDetective("catcat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.NotEqual(-42, newStringDetective.Search());
    }
    [Fact]
    public void Search_returnoccurancesoffullword_true()
    {
      StringDetective newStringDetective = new StringDetective("catcatcat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal(3, newStringDetective.Search());
    }


  }



}
