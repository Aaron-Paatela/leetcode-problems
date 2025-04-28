// Written By Aaron Paatela
// 4/28/2025

// This is the Solution class for the easy leetcode problem 'Maximum Number of Balloons'
// Please see Main Program for problem details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Maximum_Number_of_Balloons
{
    public class MaximumNumberofBalloonsSolution
    {
        public static int MaxNumberOfBalloons(string text)
        {
            int result = text.Length;
            Dictionary<char, int> letterTracker = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (letterTracker.ContainsKey(c))
                {
                    letterTracker[c]++;
                }
                else
                {
                    letterTracker.Add(c, 1);
                }
            }

            int b = letterTracker.ContainsKey('b') ? letterTracker['b'] : 0;
            int a = letterTracker.ContainsKey('a') ? letterTracker['a'] : 0;
            int l = letterTracker.ContainsKey('l') ? letterTracker['l'] / 2 : 0;
            int o = letterTracker.ContainsKey('o') ? letterTracker['o'] / 2 : 0;
            int n = letterTracker.ContainsKey('n') ? letterTracker['n'] : 0;

            int min = b;
            if (a < min)
            {
                min = a;
            }
            if (l < min)
            {
                min = l;
            }
            if (o < min)
            {
                min = o;
            }
            if (n < min)
            {
                min = n;
            }
            return min;


            


        }



    }
}
