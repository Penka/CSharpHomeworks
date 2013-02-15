using System;
using System.Collections.Generic;
class Surface
{
    /*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
*/
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("AltitudeA = ");
        int h = int.Parse(Console.ReadLine());
        Console.Write("alpha = ");
        int alpha = int.Parse(Console.ReadLine());

        double surface = (h * a) / 2.0;
        Console.WriteLine("{0:00000}", surface);

        double p = (a + b + c) / 2.0;
        surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("{0:00000}", surface);

        surface = (a * b * Math.Sin(Math.PI * alpha / 180)) / 2.0;
        Console.WriteLine("{0:00000}", surface);

    }
}

