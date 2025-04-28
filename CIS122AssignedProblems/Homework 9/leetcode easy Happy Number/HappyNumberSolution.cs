// Written By Aaron Paatela
// 4/22/2025

// This is my solution class for the easy leetcode problem 'Happy Number'
// Problem details here: https://leetcode.com/problems/happy-number/description/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Happy_Number
{
    public class HappyNumberSolution
    {

        public static bool IsHappy(int n)
        {
            HashSet<int> map = new HashSet<int>();

            while (!map.Contains(n))
            {
                map.Add(n);
                int newValue = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    newValue += digit * digit;
                    n /= 10;
                }

                if (newValue == 1) return true;
                n = newValue;
            }

            return false;
        }
    }
}
