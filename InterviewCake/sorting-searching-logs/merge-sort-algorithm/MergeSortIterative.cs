using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.sorting_searching_logs.merge_sort_algorithm
{
    public class MergeSortIterative
    {
        // based on https://www.youtube.com/watch?v=6pV2IF0fgKY&t=6s&pbjreload=10

        public static int[] MergeSort(int[] items)
        {
            List<List<int>> subLists = new List<List<int>>(items.Count());

            // N lists for every item to begin with
            foreach (int item in items)
            {
                subLists.Add(new List<int>(new int[] { item }));
            }

            do
            {
                // with every pass we should halve the number of lists
                // if the number of lists is odd the the last list would be merged in the end

                int combinedSize = subLists.Count / 2 + (subLists.Count % 2); // second term would be 1 for off numbered count
                 List<List<int>> combinedPairs = new List<List<int>>(combinedSize);

                // 2-way merge each list pair i.e 0 & 1, 2 & 3, 4 & 5 and so on...
                for (int i = 1; i < subLists.Count; i+=2)
                {
                    // handle two lists at a time at indices "i" & "i-1" and merge them
                    List<int> left = subLists[i - 1];
                    List<int> right = subLists[i];
                    List<int> merged = new List<int>(left.Count + right.Count);

                    // Two way merge
                    int leftIndex = 0;
                    int rightIndex = 0;

                    while (leftIndex < left.Count && rightIndex < right.Count)
                    {
                        if (left[leftIndex] <= right[rightIndex])
                        {
                            merged.Add(left[leftIndex]);
                            leftIndex++;
                        }
                        else
                        {
                            merged.Add(right[rightIndex]);
                            rightIndex++;
                        }
                    }

                    while (leftIndex < left.Count)
                    {
                        merged.Add(left[leftIndex]);
                        leftIndex++;
                    }

                    while (rightIndex < right.Count)
                    {
                        merged.Add(right[rightIndex]);
                        rightIndex++;
                    }

                    combinedPairs.Add(merged);
                }

                // for odd numbers sub-lists add the last list - this will be merged last
                if (subLists.Count % 2 == 1)
                    combinedPairs.Add(subLists[subLists.Count - 1]);

                subLists = combinedPairs; // combinedPairs would now be fed into next iteration for another round of merge

            } while (subLists.Count() != 1);

            return subLists[0].ToArray();
        }
    }
}
