using System;
using MathNet.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Math .NET Calculator.");
        double a = 3;
        double b = 4;

        double result = SpecialFunctions.Hypotenuse(a, b);
        Console.WriteLine($"Hypotenuse of {a}, {b} is: {result}");
    }
}