using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Brackets
{
    
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = input.Length;
        BigInteger[,] result = new BigInteger[n + 1, n + 2];
        result[0, 0] = 1;
        for (int currentCharacterIndex = 1; currentCharacterIndex <= input.Length; currentCharacterIndex++)
        {
            char currentCharacter = input[currentCharacterIndex - 1];
            if (currentCharacter == '(')
            {
                result[currentCharacterIndex, 0] = 0; // our last bracket is (
            }
            else 
            {
                result[currentCharacterIndex, 0] = result[currentCharacterIndex - 1, 1];
            }
            for (int openBracketsRemaining = 1; openBracketsRemaining < input.Length; openBracketsRemaining++)
            {
                if (currentCharacter == '?')
                {
                    result[currentCharacterIndex, openBracketsRemaining] = result[currentCharacterIndex - 1, openBracketsRemaining - 1] + // we change ? with (
                                                                          result[currentCharacterIndex - 1, openBracketsRemaining + 1];   // we change ? with )
                }
                else if (currentCharacter == ')')
                {
                    result[currentCharacterIndex, openBracketsRemaining] = result[currentCharacterIndex - 1, openBracketsRemaining + 1];
                }
                else //currentCharacter is (
                {
                    result[currentCharacterIndex, openBracketsRemaining] = result[currentCharacterIndex - 1, openBracketsRemaining - 1];
                }
            }
        }
        Console.WriteLine(result[n, 0]);
    }
}

