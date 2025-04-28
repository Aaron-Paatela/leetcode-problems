// Written By Aaron Paatela
// 4/17/2025

// This is the Solution class for the easy leetcode problem 'Number of Students Unable to Eat Lunch'
// problem details here: https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_easy_Number_of_Students_Unable_to_Eat_Lunch
{
    public class NumberOfStudentsUnableToEatLunchSolution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new Queue<int>(students);
            Queue<int> sandwichQueue = new Queue<int>(sandwiches);

            int unableToEat = studentQueue.Count; 
            int n = studentQueue.Count; 
            int consecutiveNoMatch = 0;

            while (studentQueue.Count > 0 && sandwichQueue.Count > 0 && consecutiveNoMatch < studentQueue.Count)
            {
                int currentStudentPreference = studentQueue.Peek();
                int currentSandwichType = sandwichQueue.Peek();

                if (currentStudentPreference == currentSandwichType)
                {
                    studentQueue.Dequeue();
                    sandwichQueue.Dequeue();
                    unableToEat--;
                    consecutiveNoMatch = 0; 
                }
                else
                {
                    
                    studentQueue.Dequeue();
                    studentQueue.Enqueue(currentStudentPreference);
                    consecutiveNoMatch++;
                }
            }

            return unableToEat;


        }


    }
}
