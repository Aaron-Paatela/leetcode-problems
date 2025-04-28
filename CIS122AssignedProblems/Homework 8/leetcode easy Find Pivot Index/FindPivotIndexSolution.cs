// Written BY Aaron Paatela
// 4/14/2025

// This is the Solution class for the easy leetcode problem Find Pivot Index
// Problem description here: https://leetcode.com/problems/find-pivot-index/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Find_Pivot_Index
{
    public class FindPivotIndexSolution
    {
        public static int PivotIndex(int[] nums)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                sumRight += nums[i];
            }
            if (sumLeft == sumRight)
            {
                return 0;
            }

            for (int j = 1; j < nums.Length; j++)
            {
                sumLeft += nums[j - 1];
                sumRight -= nums[j];
                if (sumLeft == sumRight)
                {
                    return j;
                }
            }
            return -1;

            // original attempt
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    int leftSide = 0;
            //    int rightSide = 0;
            //    for (int j = i + 1; j < nums.Length - 1; j++)
            //    {
            //        rightSide += nums[j];
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        leftSide += nums[k];
            //    }
            //    if (leftSide == rightSide)
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }
    }
}
