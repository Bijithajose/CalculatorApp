using System;
using MathNet.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Math .NET Calculator.");
        double a = 3;
        double b = 4;
        double c = 31.2112;

        double result = SpecialFunctions.Hypotenuse(a, b);
        Console.WriteLine($"Hypotenuse of {a}, {b} is: {result}");
        double result1 = SpecialFunctions.Gamma(c);
        Console.WriteLine($"Gamma of {c} is: {result1}");
    }
}