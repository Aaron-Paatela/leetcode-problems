// Written By Aaron Paatela
// 4/10/2025

// This is my solution class for the easy leetcode problem 'First Unique Character In A String'
// problem details here: https://leetcode.com/problems/first-unique-character-in-a-string/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Leetcode_First_Unique_Character_In_a_String
{
    public class FirstUniqueCharacterInAStringSolution
    {

        public static int FirstUniqChar(string s)
        {
            int[] counts = new int[26];
            foreach (char c in s)
            {
                counts[c - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i] - 'a'] == 1)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
