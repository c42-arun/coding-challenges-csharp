using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.greedy_algorithms
{
    // Fisher-Yates shuffle
    public class InPlaceShuffle
    {
        private static Random _rand = new Random();

        private static int GetRandom(int floor, int ceiling)
        {
            return _rand.Next(floor, ceiling + 1);
        }

        public static void Shuffle(int[] theArray)
        {
            // If it's 1 or 0 items, just return
            if (theArray.Length <= 1)
            {
                return;
            }

            // NOTICE we loop till last but one item
            // Walk through from beginning to end
            for (int indexWeAreChoosingFor = 0;
                    indexWeAreChoosingFor < theArray.Length - 1; indexWeAreChoosingFor++)
            {
                // NOTICE we ask random from already placed index 
                // Choose a random not-yet-placed item to place there
                // (could also be the item currently in that spot).
                // Must be an item AFTER the current item, because the stuff
                // before has all already been placed
                int randomChoiceIndex = GetRandom(indexWeAreChoosingFor, theArray.Length - 1);

                // Place our random choice in the spot by swapping
                if (randomChoiceIndex != indexWeAreChoosingFor)
                {
                    int valueAtIndexWeChoseFor = theArray[indexWeAreChoosingFor];
                    theArray[indexWeAreChoosingFor] = theArray[randomChoiceIndex];
                    theArray[randomChoiceIndex] = valueAtIndexWeChoseFor;
                }
            }
        }
    }
}
