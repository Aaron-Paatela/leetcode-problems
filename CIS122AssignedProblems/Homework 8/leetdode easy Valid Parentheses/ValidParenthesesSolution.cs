// Written By Aaron Paatela

// 4/17/2025

// This is the Solution class for the easy leetcode problem Valid Parentheses
// problem details here: https://leetcode.com/problems/valid-parentheses/description/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetdode_easy_Valid_Parentheses
{
    internal class ValidParenthesesSolution
    {


        public static bool IsValid(string s)
        {
            HashSet<char> OpenParentheses = new HashSet<char>() { '[', '{', '(' };
            Stack<char> myStack = new Stack<char>();
            foreach (char c in s)
            {
                if (OpenParentheses.Contains(c))
                {
                    myStack.Push(c);
                }
                if (myStack.Count == 0)
                {
                    return false;
                }    
                else if (c == ')')
                {
                    if (myStack.Peek().ToString() == "(")
                    {
                        myStack.Pop();
                    }    
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (myStack.Peek().ToString() == "{")
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (myStack.Peek().ToString() == "[")
                    {
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (myStack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
