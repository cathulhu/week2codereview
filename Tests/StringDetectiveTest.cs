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
    //will handle -42 as special case on razor page
    [Fact]
    public void Search_PartialDoesntClaimFullmatch_false()
    {
      StringDetective newStringDetective = new StringDetective("catcat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.NotEqual(1, newStringDetective.Search());
    }
    //string with multiple versions of target should NOT register as equivolent
    [Fact]
    public void Search_returnOccurancesOfFullword_true()
    {
      StringDetective newStringDetective = new StringDetective("catcatcat", "cat");
      Assert.Equal(3, newStringDetective.Search());
    }
    //standard detection behaviour to find subwords that match target in composition and order of letters;

      //str len = 9, tar length = 3, moves till end 6
      //first substring should be 0 to 2

      //bug behaviour searchbounds =6 when they should equal 2...
      //bug behaviour substring getting longer each time, catc, atcat, tcatca

      //first tackling search bounds
        //first problem was searchbounds was being changed every loop iteration vs a static lenght of target (moved out of loop)
        //second problem was I wasn't returning propper data for my debug statement, (was returning moves unti oult of bounds, not index and index+search bound <-- gives begining and end coordinate to search)
        //third problem loop wasn't running enough times, logic check should have been movesUntilOutOfBounds >= so that the last char actually gets check

      //substring length abbaration was occuring because search bounds were getting declared each iteration of the loop (thus changing because they are based on moves until out of bounds)

      [Fact]
      public void Search_returnOccurancesOfFullWordWithInteruptionsAndNonSequence_true()
      {
        StringDetective newStringDetective = new StringDetective("catzzacatcatacartcat", "cat");
        //  Console.WriteLine("Test output: " + newAnagram.GetInput());
        Assert.Equal(4, newStringDetective.Search());
      }

  }



}
