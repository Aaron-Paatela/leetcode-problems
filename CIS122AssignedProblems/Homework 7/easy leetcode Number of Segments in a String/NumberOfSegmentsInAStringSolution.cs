// Written By Aaron Paatela
// 4/10/2025

// This is my solution class for the easy leetcode problem 'Number Of Segments in A String'
// problem details here: https://leetcode.com/problems/number-of-segments-in-a-string/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_leetcode_Number_of_Segments_in_a_String
{
    public class NumberOfSegmentsInAStringSolution
    {
        public static int CountSegments(string s)
        {
            return s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }
}
