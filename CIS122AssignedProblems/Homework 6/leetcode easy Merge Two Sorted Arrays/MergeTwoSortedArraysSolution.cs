// Written By Aaron Paatela
// 4/2/2025

// This is the Solution class for the easy leetcode problem 'Merge Sorted Arrays'
// Please see Main Program for problem details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Merge_Two_Sorted_Arrays
{
    public class MergeTwoSortedArraysSolution
    {

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[m + i] = nums2[i];
            }

            bool swap = false;
            int temp = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                swap = false;
                for (int a = 0; a < nums1.Length - i - 1; a++)
                {
                    if (nums1[a] > nums1[a + 1])
                    {
                        temp = nums1[a];
                        nums1[a] = nums1[a + 1];
                        nums1[a + 1] = temp;
                        swap = true;
                    }

                }
                if (swap == false)
                {
                    break;
                }
            }
        }
    }
}
