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
      Assert.Equal(1, newStringDetective.Search());
    }


  }



}
