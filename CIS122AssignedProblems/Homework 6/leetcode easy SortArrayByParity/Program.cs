// Written By Aaron Paatela
// 4/1/2025

//This is the Main Program to test the solution for the easy leetcode problem 'Sort Array By Parity'
// leetcode problem details: https://leetcode.com/problems/sort-array-by-parity/description/


namespace leetcode_easy_SortArrayByParity
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] inputnumbers = new int[] { 1, 5, 3, 2, 4, 8, 7 };

            int[] myReturnArray = SortArrayByParitySolution.SortArrayByParity(inputnumbers);


            Console.Write($"[{string.Join(", ", myReturnArray)}]");
        }
    }
}
