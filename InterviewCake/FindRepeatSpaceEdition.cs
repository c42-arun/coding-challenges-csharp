using System;

namespace InterviewCake.sorting
{
    public class FindRepeatSpaceEdition
    {
        public static int FindRepeat(int[] theArray)
        {
            // Find a number that appears more than once

            // Not sure if sorting this is right thing to do
            // But if this is a quick sort would be O(1) space?
            Array.Sort(theArray);

            int floor = -1;
            int ciel = theArray.Length;

            while (floor + 1 < ciel)
            {
                var midPoint = ((ciel - floor) / 2) + floor;

                var valueAtMid = theArray[midPoint];

                if (valueAtMid == midPoint + 1)
                {
                    // no dups from floor through mid, so move the floor up
                    floor = midPoint;
                }
                else
                {
                    if ((midPoint < ciel - 1) && theArray[midPoint] == theArray[midPoint + 1])
                        return theArray[midPoint];

                    if ((midPoint > floor + 1) && theArray[midPoint - 1] == theArray[midPoint])
                        return theArray[midPoint];

                    // dups between floor and mid, so bring down the ceil
                    ciel = midPoint;
                }
            }

            return floor > -1 ? theArray[floor] : theArray[ciel];
        }
    }
}
