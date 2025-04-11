// Written By Aaron Paatela
// 4/1/2025

// This is the solution class for easy leetcode Needle in Haystack problem
// (aka 'Find the Index of the First Occurrence in a String' problem.)
// Please see Main Program for problem details

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Needle_in_Haystack
{
    public class NeedleInHaystackSolution
    {
        public static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    for (int a = 0; a < needle.Length; a++)
                    {
                        if (haystack[i+a] != needle[a])
                        {
                            break;
                        }
                        if (haystack[i + a] == needle[a] && a == needle.Length - 1)
                        {
                            return i;
                        }

                    }
                }

            }
            return -1;

        }

    }
}
