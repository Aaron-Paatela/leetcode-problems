// Written By Aaron Paatela
// 4/22/2025

// This is my Solution class for the easy leetcode problem 'Move Zeroes'
// Problem details here: https://leetcode.com/problems/move-zeroes/submissions/1620313724/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Move_Zeroes
{
    public class MoveZeroesSolution
    {

        public static void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return;
            }

            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[current++] = nums[i];
                }
            }
            for (; current < nums.Length; current++)
            {
                nums[current] = 0;
            }
        }
    }
}
