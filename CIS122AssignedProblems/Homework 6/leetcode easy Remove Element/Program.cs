// Written By Aaron Paatela
// 4/2/2025

// This is the Main Program to test my solution for easy leetcode 'Remove Element' problem.
// link to problem: https://leetcode.com/problems/remove-element/description/

namespace leetcode_easy_Remove_Element
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[] { 3, 2, 2, 3 };

            int value = 3;

            int result = RemoveElementSolution.RemoveElement(ints, value);

            Console.WriteLine(result);

            Console.Write($"[{string.Join(", ", ints)}]");
            
        }
    }
}
