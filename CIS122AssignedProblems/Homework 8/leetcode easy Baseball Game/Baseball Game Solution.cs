// Written By Aaron Paatela
// 4/15/2025

// This is the Solution class for leetcode easy problem Baseball Game.
// Problem details located here:  https://leetcode.com/problems/baseball-game/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Baseball_Game
{
    public class Baseball_Game_Solution
    {
        public static int CalPoints(string[] operations)
        {
            List<int> ScoreTracker = new List<int>();
            int i = 0;

            foreach (string s in operations)
            {
                if (s == "+")
                {
                    ScoreTracker.Add(ScoreTracker[i - 1] + ScoreTracker[i - 2]);
                    i++;
                }
                else if (s == "D")
                {
                    ScoreTracker.Add(2 * ScoreTracker[i - 1]);
                    i++;
                }
                else if (s == "C")
                {
                    ScoreTracker.RemoveAt(ScoreTracker.Count - 1);
                    i--;
                }
                else
                {
                    ScoreTracker.Add(Convert.ToInt32(s));
                    i++;
                }
            }
            int result = 0;
            foreach (int j in ScoreTracker)
            {
                result += j;
            }
            return result;
        }

    }
}

