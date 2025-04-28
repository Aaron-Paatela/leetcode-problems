// Written By Aaron Paatela
// 4/14/2025

// This is the Main Program to test the logic used for easy leetcode problem Find Pivot Index
// Problem description here: https://leetcode.com/problems/find-pivot-index/description/


namespace leetcode_easy_Find_Pivot_Index
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] testInts = new int[] { 2, 1, -1 };

            int result = FindPivotIndexSolution.PivotIndex(testInts);

            Console.WriteLine(result);
            
        }
    }
}
