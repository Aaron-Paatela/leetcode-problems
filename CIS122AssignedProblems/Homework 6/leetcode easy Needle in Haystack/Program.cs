// Written By Aaron Paatela
// 4/1/2025

// This is the Main Program to test my solution for easy leetcode 'Needle in HayStack' problem
// (aka 'Find the Index of the First Occurrence in a String' problem.)
// link to problem: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/


namespace leetcode_easy_Needle_in_Haystack
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string myHaystack = "bannana";
            string myNeedle = "ana";

            int result = NeedleInHaystackSolution.StrStr(myHaystack, myNeedle);

            Console.WriteLine(result);
            
        }
    }
}
