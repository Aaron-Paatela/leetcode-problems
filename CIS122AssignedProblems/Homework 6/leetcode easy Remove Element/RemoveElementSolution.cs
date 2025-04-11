// Written By Aaron Paatela
// 4/2/2025

// This is the solution class for easy leetcode 'Remove Element' problem
// Please see Main Program for problem details


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Remove_Element
{
    public  class RemoveElementSolution
    {

        public static int RemoveElement(int[] nums, int val)
        {

            // my new solution after brute forcing my initial answer
            int NonValNums = 0;

            foreach (int i in nums)
            {
                if (i != val)
                {
                    nums[NonValNums] = i;
                    NonValNums++;
                }
            }
            return NonValNums;

            // my initial solution. 

            //int k = nums.Length;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == val)
            //    {
            //        nums[i] = int.MaxValue;
            //        k--;
            //    }
            //}

            //for (int i = 0; i < nums.Length- 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - i - 1; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}
            //return k;


        }
    }
}
