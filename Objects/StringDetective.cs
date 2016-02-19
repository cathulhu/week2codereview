using System;
using System.Linq;
using System.Collections.Generic;

namespace StringDetectiveNamespace
{
  public class StringDetective
  {
    private string _candidateString;
    private string _targetString;
    //private int array for occurances would be here I think


      public StringDetective (string stringToSearch, string target)
      {
        _candidateString=stringToSearch;
        _targetString=target;
        //maybe put a data structure here to store locations of matches?
      }

      public int Search()
      {
        int numOfOccurances = 0;
        int targetlength = 0;
        int movesUntilOutOfBounds = 0;
        char[] candidateToArray;
        // char[] targetToArray; don't need this
        string subSearchCandidate;

        if (_candidateString == _targetString)  //testing if strings are 100% identical saves time, especially for big strings
        {
          numOfOccurances=-42;
        }

        else
        {
          candidateToArray = new char[_candidateString.Length];
          candidateToArray = _candidateString.ToCharArray();
          targetlength = _targetString.Length;
          movesUntilOutOfBounds = _candidateString.Length - targetlength;

          for (int i=0; movesUntilOutOfBounds > 0 ; i++)
          {
            Console.WriteLine("Search Coord:" + i + " " + movesUntilOutOfBounds);
            subSearchCandidate= _candidateString.Substring( i, (i+movesUntilOutOfBounds-1) );
            //  |xxx|xx   x|xxx|x   xx|xxx|
            //  0-2        1-3        2-4
            if (subSearchCandidate == _targetString)
            {
              numOfOccurances++;
            }
            movesUntilOutOfBounds--;
          }

        }

        return numOfOccurances;
      }
  }

}
