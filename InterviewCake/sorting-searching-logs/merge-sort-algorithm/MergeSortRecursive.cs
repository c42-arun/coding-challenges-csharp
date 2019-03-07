using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.sorting_searching_logs.merge_sort_algorithm
{
    // based pn https://www.youtube.com/watch?v=TzeBrDU-JaY
    public class MergeSortRecursive
    {
        public static int[] MergeSort(int[] items)
        {
            if (items.Length < 2) return items;

            int mid = items.Length / 2;

            int[] leftHalf = new int[mid];
            int[] rightHalf = new int[items.Length - mid];

            for(int i = 0; i<leftHalf.Length; i++)
            {
                leftHalf[i] = items[i];
            }

            for(int j = 0; j<rightHalf.Length; j++)
            {
                rightHalf[j] = items[j + mid];
            }

            int[] sortedLeftHalf = MergeSort(leftHalf);
            int[] sortedRightHalf = MergeSort(rightHalf);

            int left = 0;
            int right = 0;
            int ret = 0;

            while (left < sortedLeftHalf.Length && right < sortedRightHalf.Length)
            {
                if (sortedLeftHalf[left] <= sortedRightHalf[right])
                {
                    items[ret] = sortedLeftHalf[left];
                    left++;
                }
                else
                {
                    items[ret] = sortedRightHalf[right];
                    right++;
                }
                ret++;
            }

            while (left < sortedLeftHalf.Length)
            {
                items[ret] = sortedLeftHalf[left];
                left++;
                ret++;
            }
            while (right < sortedRightHalf.Length)
            {
                items[ret] = sortedRightHalf[right];
                right++;
                ret++;
            }

            return items;
        }
    }
}
