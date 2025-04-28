// Written By Aaron Paatela
// 4/8/2025

// This is the Solution class for the easy leetcode problem 'Robot Return to Origin'
// Please see Main Program for problem details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_leetcode_Robot_Return_to_Origin
{
    public class RobotReturnToOriginSolution
    {
        public static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            foreach (char c in moves)
            {
                if (c == 'U')
                {
                    y++;
                }
                else if (c == 'D')
                {
                    y--;
                }
                else if (c == 'L')
                {
                    x--;
                }
                else if (c == 'R')
                {
                    x++;
                }
            }
            if (x == 0 && y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
