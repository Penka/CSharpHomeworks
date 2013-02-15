using System;
using System.Collections.Generic;

class AirplaneDrinks
{


    static bool HaveToServeTea(int seatNumber, int[] teaPassangers)
    {
        for (int i = 0; i < teaPassangers.Length; i++)
        {
            if (seatNumber == teaPassangers[i] - 1)
            {
                return true;
            }
        }
        return false;
    }

    static long MinServeSteps(int n, int[] teaPassangers)
    {
        long minSteps = 4 * n; //time to serve all passangers

        int teaCount = 0;
        int coffeeCount = 0;
        long lastServedTea = 0;
        long lastServedCoffee = 0;
        bool[] haveToServeTea = new bool[n];


        for (int j = 0; j < teaPassangers.Length; j++)
        {
            haveToServeTea[teaPassangers[j] - 1] = true;
        }

        for (int i = n - 1; i >= 0; i--)
        {

            if (haveToServeTea[i])
            {
                teaCount++;
                if (lastServedTea < i + 1)
                {
                    lastServedTea = i + 1;
                }
            }
            else
            {
                coffeeCount++;
                if (lastServedCoffee < i + 1)
                {
                    lastServedCoffee = i + 1;
                }
            }
            if (coffeeCount == 7) //refill coffee
            {
                coffeeCount = 0;
                minSteps += lastServedCoffee * 2;
                minSteps += 47;
                lastServedCoffee = 0;
            }
            if (teaCount == 7) //refill tea
            {
                teaCount = 0;
                minSteps += lastServedTea * 2;
                minSteps += 47;
                lastServedTea = 0;
            }

        }
        if (coffeeCount != 0)
        {
            minSteps += lastServedCoffee * 2;
            minSteps += 47;
        }
        if (teaCount != 0)
        {
            minSteps += lastServedTea * 2;
            minSteps += 47;
        }
        return minSteps;

    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int teaCount = int.Parse(Console.ReadLine());
        int[] teaPassangers = new int[teaCount];
        for (int i = 0; i < teaCount; i++)
        {
            teaPassangers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(MinServeSteps(n, teaPassangers));
    }
}

