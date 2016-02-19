using System;
using System.Collections.Generic;
using Xunit;

namespace StringDetectiveNamespace
{
  public class StringDetective
  {
    [Fact]
    public void StringDetective_Matching_true()
    {
      StringDetective newStringDetective = new StringDetective("someinput?");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal("someinput", newStringDetective.Dosomething());
    }


  }



}
