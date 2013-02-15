using System;
using System.Collections.Generic;
/*Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/
class CorrectExpression
{
    static bool IsCorrectExpression(string expression)
    {
        int countBrackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countBrackets++;
            }
            else if (expression[i] == ')')
            {
                if (countBrackets == 0)
                {
                    return false;
                }
                else countBrackets--;
            }
        }

        return countBrackets == 0;
    }
    static void Main(string[] args)
    {
        string expression = "((a+b)/5-d)";
        bool isCorrect = IsCorrectExpression(expression);
        if (isCorrect)
        {
            Console.WriteLine("The given expression is correct");
        }
        else
        {
            Console.WriteLine("The given expression is not correct");
        }


        expression = ")(a+b))";
        isCorrect = IsCorrectExpression(expression);
        if (isCorrect)
        {
            Console.WriteLine("The given expression is correct");
        }
        else
        {
            Console.WriteLine("The given expression is not correct");
        }
    }
}
