using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.sorting_searching_logs
{
    public static class RotationPoint
    {
        public static int FindRotationPoint(string[] words)
        {
            // use binary search for this "sorted" string array

            int floor = -1;
            int ceiling = words.Length;

            string firstWord = words[0];

            while (floor + 1 < ceiling)
            {
                // find halfway index
                int midDistance = (ceiling - floor) / 2;
                int midIndex = floor + midDistance;

                // see if this is the rotation point i.e preceding & succeeding word would rank higher
                string thisWord = words[midIndex];

                // if we have reached first item
                if (midIndex == 0)
                {
                    string next = words[midIndex + 1];

                    if (thisWord.CompareTo(next) < 0)
                        return midIndex;
                    else
                        return midIndex + 1;
                }

                // if we have reached last item
                if (midIndex == words.Length-1)
                {
                    string previous = words[midIndex - 1];

                    if (thisWord.CompareTo(previous) < 0)
                        return midIndex;
                    else
                        return midIndex - 1;
                }

                string prevWord = words[midIndex - 1];
                string nextWord = words[midIndex + 1];

                if (thisWord.CompareTo(prevWord) < 0 && thisWord.CompareTo(nextWord) < 0)
                    return midIndex;

                // if this is lower than the first word then there could be lower ones to the left
                if (thisWord.CompareTo(firstWord) < 0)
                {
                    ceiling = midIndex;
                }
                else
                {
                    // if this is higher than first word then the rotation point is located further right
                    floor = midIndex;
                }
            }

            return -100;
        }
    }
}
