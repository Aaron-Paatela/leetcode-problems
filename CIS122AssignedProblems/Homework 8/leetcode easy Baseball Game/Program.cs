// Written By Aaron Paatela
// 4/15/2025

// This is the Main Program for leetcode easy problem Baseball Game.
// Problem details located here:  https://leetcode.com/problems/baseball-game/description/



namespace leetcode_easy_Baseball_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] testOps = new string[] { "5", "2", "C", "D", "+" };

            int result = Baseball_Game_Solution.CalPoints(testOps);

            Console.WriteLine(result);

            
        }
    }
}
