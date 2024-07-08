using System;
using System.Linq;

class StandardDeviationCalculator
{
    public static double StandardDeviation(int  [] arr)
    {

        // Calculate sum of array elements
        double sum = arr.Sum();
     

        // Calculate average of array elements
        double average = (double)sum / arr.Length;


        // Calculate sum of squares of differences from the mean
        double sumOfSquares = 0;
        foreach (var item in arr)
        {
            var difference = item - average;
            sumOfSquares += Math.Pow(difference ,2);
        }


        // Calculate variance and standard deviation
        double variance = sumOfSquares / arr.Length; // updated line
        double standardDeviation = Math.Sqrt(variance);

        return standardDeviation;
    }
}
