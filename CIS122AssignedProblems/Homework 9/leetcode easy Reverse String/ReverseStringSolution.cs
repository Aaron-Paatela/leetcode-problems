// Written By Aaron Paatela
// 4/22/2025

// This is my solution class for the easy leetcode problem 'Reverse String'
// Problem details here: https://leetcode.com/problems/reverse-string/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Reverse_String
{
    public class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            if (s == null || s.Length == 0)
            {
                return;
            }

            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;

                i++; 
                j--;
            }
        }
    }
}
