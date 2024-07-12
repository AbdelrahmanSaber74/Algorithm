using System;

public class MergeSort
{
    // Method to merge two halves
    public void Merge(int[] array, int left, int mid, int right)
    {
        // Find sizes of two subarrays to be merged
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Create temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, mid + 1, rightArray, 0, n2);

        // Initial indexes of first and second subarrays
        int i = 0, j = 0;

        // Initial index of merged subarray array
        int k = left;
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of leftArray[], if any
        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        // Copy remaining elements of rightArray[], if any
        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }

    // Main function that sorts array[left..right] using merge()
    public void MergeSortAlgorithm(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point
            int mid = left + (right - left) / 2;

            // Sort first and second halves
            MergeSortAlgorithm(array, left, mid);
            MergeSortAlgorithm(array, mid + 1, right);

            // Merge the sorted halves
            Merge(array, left, mid, right);
        }
    }

    // Method for printing the array
    public void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
