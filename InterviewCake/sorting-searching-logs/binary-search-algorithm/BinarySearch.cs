using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.sorting_searching_logs.binary_search_algorithm
{
    public static class BinarySearch
    {
        public static bool Exists(int numberToFind, int[] sortedArray)
        {
            // all the items should fall inside the index we are searching
            // so floor should be 1 less than 0 and ceiling 1 more than (n-1)
            // if we select them as 0 & (n-1) then we will miss if the number we are looking 
            // is the first or the last item!
            int floor = -1;
            int ceiling = sortedArray.Length;

            // we search till there is at least 1 item between the area index we search
            while (floor + 1 < ceiling)
            {
                int midDistance = (ceiling - floor) / 2;
                int midPoint = floor + midDistance; // get the index in the middle

                Console.WriteLine($"Mid distance: {midDistance}, Mid point: {midPoint}, Mid value: {sortedArray[midPoint]}");

                if (sortedArray[midPoint] == numberToFind)
                    return true;

                // the number should exist to the left, so bring down the ceiling
                if (sortedArray[midPoint] > numberToFind)
                {
                    ceiling = midPoint;
                }
                else
                {
                    // number should exist to the right, so bring up the floor
                    floor = midPoint;
                }
            }

            return false; // we haven't found it
        }
    }
}
