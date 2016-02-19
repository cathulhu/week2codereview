using System;
using System.Collections.Generic;
using Xunit;

namespace RepeatCounterNameSpace
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_Matchingwholestring_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }

    [Fact]
    public void CountRepeats_PartialDoesntClaimFullmatch_false()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("catcat", "cat");
      //  Console.WriteLine("Test output: " + newAnagram.GetInput());
      Assert.NotEqual(1, newRepeatCounter.CountRepeats());
    }
    //string with multiple versions of target should NOT register as equivolent
    [Fact]
    public void CountRepeats_returnOccurancesOfFullword_true()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("catcatcat", "cat");
      Assert.Equal(3, newRepeatCounter.CountRepeats());
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
      public void CountRepeats_returnOccurancesOfFullWordWithInteruptionsAndNonSequence_true()
      {
        RepeatCounter newRepeatCounter = new RepeatCounter("catzzacatcatacartcat", "cat");
        //  Console.WriteLine("Test output: " + newAnagram.GetInput());
        Assert.Equal(4, newRepeatCounter.CountRepeats());
      }

  }



}
