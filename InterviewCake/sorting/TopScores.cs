using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.sorting
{
    public static class TopScores
    {
        public static int[] SortScores(int[] unorderedScores, int highestPossibleScore)
        {
            // Sort the scores in O(n) time
            int[] sortedScores = new int[unorderedScores.Length];
            int[] scoreCounts = new int[highestPossibleScore + 1];

            foreach (int s in unorderedScores)
            {
                scoreCounts[s]++;
            }

            int rankIndex = 0;

            for(int i = highestPossibleScore; i >= 0; i--)
            {
                while(scoreCounts[i] > 0)
                {
                    sortedScores[rankIndex] = i;
                    scoreCounts[i]--;

                    rankIndex++;
                }
            }

            return sortedScores;
        }
    }
}
