// Written By Aaron Paatela
// 4/2/2025

// This is the Main Program to test the answer for the easy leetcode problem 'Merge Sorted Arrays'
// leetcode problem here: https://leetcode.com/problems/merge-sorted-array/


namespace leetcode_easy_Merge_Two_Sorted_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers1 = new int[] { 2, 3, 2, 7, 4, 6, 0, 0, 0};
            int[] numbers2 = new int[] {2, 3, 5};
            int numbers1Length = 6;
            int numbers2Length = 3;

            MergeTwoSortedArraysSolution.Merge(numbers1, numbers1Length, numbers2, numbers2Length);

            Console.Write($"[{string.Join(", ", numbers1)}]");
        }
    }
}
