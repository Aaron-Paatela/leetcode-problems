// Written By Aaron Paatela
// 4/1/2025

// This is the solution class for the SortArrayByParity


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_SortArrayByParity
{
    public class SortArrayByParitySolution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int length = nums.Length;
            int[] returnArray = new int[length];
            int j = 0;
            int a = length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    returnArray[j++] = nums[i];

                }
                else
                {
                    returnArray[a--] = nums[i];
                }
            }
            return returnArray;
        }



    }
}
