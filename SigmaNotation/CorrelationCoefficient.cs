using System;
using System.Linq;

class CorrelationCoefficientCalculator
{
    public static void CorrelationCoefficient(int[] x, int[] y)
    {
        // Validate input arrays
        if (x == null || y == null || x.Length != y.Length)
        {
            throw new ArgumentException("Input arrays must not be null and must have equal length.");
        }

        int n = x.Length;

        // Calculate sums and sum of squares
        double sumX = x.Sum();
        double sumY = y.Sum();
        double sumXY = x.Zip(y, (a, b) => a * b).Sum(); // Using Zip to calculate sumXY
        double sumX2 = x.Sum(a => a * a);
        double sumY2 = y.Sum(b => b * b);

        // Calculate numerator and denominator
        double numerator = n * sumXY - sumX * sumY;
        double denominator = Math.Sqrt((n * sumX2 - sumX * sumX) * (n * sumY2 - sumY * sumY));

        // Check for division by zero (undefined correlation coefficient)
        if (denominator == 0)
        {
            Console.WriteLine("Denominator is zero. Correlation coefficient is undefined.");
            return;
        }

        // Calculate correlation coefficient
        double correlationCoefficient = numerator / denominator;

        Console.WriteLine($"Correlation Coefficient: {correlationCoefficient}");
    }
}
