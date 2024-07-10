using System;

public class SelectionSort
{
    // Selection Sort algorithm
    public void SelectionSortAlgorithm(int[] array)
    {
        int n = array.Length;
        // Traverse through all elements
        for (int i = 0; i < n - 1; i++)
        {
            // Assume the current element is the smallest
            int minIndex = i;

            // Find the smallest element in the remaining unsorted array
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found smallest element with the first element
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    // Method to print the array
    public void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    
}
