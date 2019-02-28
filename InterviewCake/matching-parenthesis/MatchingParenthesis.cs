using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCake.matching_parenthesis
{
    public class MatchingParenthesis
    {
        public static int O_of_N_using_Stack(string sentence, int openingParenIndex)
        {
            // Find the position of the matching closing parenthesis
            Stack<int> stack = new Stack<int>();
            int currentIndex = 0;

            foreach (char c in sentence)
            {
                if (c == '(')
                {
                    stack.Push(currentIndex);
                }
                else if (c == ')')
                {
                    int matchingOpeningIndex = stack.Pop();

                    if (matchingOpeningIndex == openingParenIndex)
                    {
                        return currentIndex;
                    }
                }

                currentIndex++;
            }

            throw new ArgumentException();
        }

        public static int O_of_1_my_solution(string sentence, int openingParenIndex)
        {
            // Find the position of the matching closing parenthesis
            int currentIndex = 0;
            int openBrackets = 0;
            int openBracketsAtOpeningParenIndex = 0;

            foreach (char c in sentence)
            {
                if (c == '(')
                {
                    openBrackets++;

                    if (currentIndex == openingParenIndex)
                    {
                        openBracketsAtOpeningParenIndex = openBrackets;
                    }
                }
                else if (c == ')')
                {
                    // if this is closing the bracket that was opened at the 
                    // index we are interested in then we've got our matching 
                    // closing braket
                    if (openBrackets == openBracketsAtOpeningParenIndex)
                    {
                        return currentIndex;
                    }

                    openBrackets--;

                    if (openBrackets < 0)
                    {
                        throw new Exception();
                    }
                }

                currentIndex++;
            }

            throw new ArgumentException();
        }

        public static int O_of_1_provided_solution(string sentence, int openingParenIndex)
        {
            // Find the position of the matching closing parenthesis
            int openBrackets = 0;

            for(int i = openingParenIndex; i < sentence.Length; i++)
            {
                if (sentence[i] == '(')
                {
                    openBrackets++;
                }
                else if (sentence[i] == ')')
                {
                    openBrackets--;

                    if (openBrackets == 0)
                        return i;
                }
            }

            throw new ArgumentException();
        }
    }
}
