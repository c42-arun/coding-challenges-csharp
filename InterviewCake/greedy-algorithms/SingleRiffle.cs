using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.greedy_algorithms
{
    public class SingleRiffle
    {
        public static bool IsSingleRiffle(int[] half1, int[] half2, int[] shuffledDeck)
        {
            // Check if the shuffled deck is a single riffle of the halves

            // Validations
            // shuffledDeck's length should equal both halves
            if ((half1.Length + half2.Length) != shuffledDeck.Length)
                return false;

            // Greedy algorithm
            int half1Index = 0;
            int half2Index = 0;

            foreach (int card in shuffledDeck)
            {
                if (half1Index < half1.Length &&
                        card == half1[half1Index])
                    half1Index++;
                else if (half2Index < half2.Length &&
                        card == half2[half2Index])
                    half2Index++;
                else
                    return false;
            }

            return true;
        }
    }
}
