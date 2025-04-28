// Written By Aaron Paatela
// 4/9/2025

// This is the Solution class for the easy leetcode problem 'Find The Differrence'
// Problem details here: https://leetcode.com/problems/find-the-difference/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_leetcode_Find_The_Difference
{
    public class FindTheDifferenceSolution
    {
        public static char FindTheDifference(string s, string t)
        {
            // Do a XOR checksum of the two strings
            char result = (char)0;
            foreach (var ch in s)
                result ^= ch;
            foreach (var ch in t)
                result ^= ch;
            //result will be the different character
            return result;
        }

    }
}
