using System;

class Program
{
    static void Main(string[] args)
    {
        int[] x = { 2, 4, 3, 5, 1 };
        int[] y = { 70, 80, 75, 85, 65 };

        Console.WriteLine("Standard Deviation of X:");
        double stdDevX = StandardDeviationCalculator.StandardDeviation(x);
        Console.WriteLine(stdDevX);

        Console.WriteLine("Standard Deviation of Y:");
        double stdDevY = StandardDeviationCalculator.StandardDeviation(y);
        Console.WriteLine(stdDevY);

        Console.WriteLine("Correlation Coefficient:");
        CorrelationCoefficientCalculator.CorrelationCoefficient(x, y);

        Console.ReadLine();
    }
}