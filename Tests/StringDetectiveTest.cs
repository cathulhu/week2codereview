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

      //str len = 9, tar length = 3, moves till end 6
      //first substring should be 0 to 2

      //bug behaviour searchbounds =6 when they should equal 2...
      //bug behaviour substring getting longer each time, catc, atcat, tcatca

      //first tackling search bounds
        //first problem was searchbounds was being changed every loop iteration vs a static lenght of target (moved out of loop)
        //second problem was I wasn't returning propper data for my debug statement, (was returning moves unti oult of bounds, not index and index+search bound <-- gives begining and end coordinate to search)
        //third problem 
  }



}
