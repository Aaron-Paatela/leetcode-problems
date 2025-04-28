// Written By Aaron Paatela
// 4/14/2025

// This is the Main Program to test my solution for easy leetcode problem 'Number of Recent Calls
// problem details here: https://leetcode.com/problems/number-of-recent-calls/description/

// Main Program not really applicable for this problem, but I can't not have a Main Program


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easy_leetcode_Number_of_Recent_Calls
{
    internal class NumberOfRecentCallsSolution
    {

        private Queue<int> queue;
        // I wasn't able to figure out how to get this to work on my own machine instead of at the leetcode site.

        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            queue.Enqueue(t);
            while (t - queue.Peek() > 3000)
                queue.Dequeue();
            return queue.Count;
        }
    }
}
