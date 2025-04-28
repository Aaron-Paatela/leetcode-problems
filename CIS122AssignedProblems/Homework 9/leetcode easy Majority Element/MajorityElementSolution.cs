// Written By Aaron Paatela
// 4/22/2025

// This is my solution class for the easy leetcode problem 'Majority Element'
// problem details here: https://leetcode.com/problems/majority-element/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Majority_Element
{
    public class MajorityElementSolution
    {


        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
