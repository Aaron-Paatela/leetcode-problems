// Written By Aaron Paatela
// 4/22/2025

// This is my solution class for the easy leetcode problem 'Length of Last Word'
// problem details here: https://leetcode.com/problems/length-of-last-word/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Length_Of_Last_Word
{
    public class LengthOfLastWordSolution
    {
        public static int LengthOfLastWord(string s)
        {
            int first_num = -1;
            int second_num = -1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ' && first_num < 0)
                {
                    first_num = i;
                }
                if (s[i] == ' ' && first_num > 0)
                {
                    second_num = i;
                    break;
                }

            }
            return first_num - second_num;
        }

    }
}
