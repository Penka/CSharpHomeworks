using System;
using System.Collections.Generic;

class AcademyTasks
{

    static int ReturnSolution(int[] tasks, int variety)
    {
        int result = tasks.Length;
        for (int i = 0; i < tasks.Length; i++)
        {
            for (int j = i + 1; j < tasks.Length; j++)
            {
                int diference = tasks[i] - tasks[j];
                if (Math.Abs(diference) >= variety)
                {
                    int firstIndex = i;
                    int secndIndex = j;
                    int stepsToFirstIndex = (firstIndex + 1) / 2 + 1;
            
                    int currentResult = (secndIndex - firstIndex + 1) / 2 + stepsToFirstIndex;
                    if (result > currentResult)
                    {
                        result = currentResult;
                    }
                }
            }
        }
        return result;
    }


    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int variety = int.Parse(Console.ReadLine());

        string[] separator = new string[] { ", " };
        string[] tasksString = input.Split(separator, StringSplitOptions.None);
        int[] tasks = new int[tasksString.Length];
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = int.Parse(tasksString[i]);
        }
        Console.WriteLine(ReturnSolution(tasks, variety));

    }
}

