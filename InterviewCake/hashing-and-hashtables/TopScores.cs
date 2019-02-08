using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.hashing_and_hashtables
{
    public class TopScores
    {
        public static int[] SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            // Sort the scores in O(n) time

            // Counting algorithm
            // Counting is a common pattern in time - saving algorithms.It can often get you O(n) runtime, but at the expense of 
            // **adding O(n) space**. The idea is to define a dictionary or array(call it e.g.counts) where the keys/ indices represent 
            // the items from the input set and the values represent the number of times the item appears. In one pass through the 
            // input you can fully populate counts:
            int[] scoreCounts = new int[highestPossibleScore + 1];

            foreach(int score in unorderedScores)
            {
                scoreCounts[score]++; // 'score' is the index and 'no.of.occurences' is the value
            }

            int[] orderedScores = new int[unorderedScores.Length];
            int currentOrderedScoresIndex = 0;

            // loop 'scoreCounts' from high to low so we rank occurences as we go
            for (int score = highestPossibleScore; score > 0; score--)
            {
                int occurences = scoreCounts[score];

                for(int i = 0; i < occurences; i++ )
                {
                    orderedScores[currentOrderedScoresIndex] = score;
                    currentOrderedScoresIndex++;
                }
            }


            return orderedScores;
        }
    }
}
