using System;

public class BinarySearch
{
    // Method for performing binary search
    public int BinarySearchAlgorithm(int[] arr, int key)
    {
        // Ensure the input array is sorted
        Array.Sort(arr);

        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == key)
            {
                return mid; // Key found, return index
            }
            else if (arr[mid] < key)
            {
                low = mid + 1; // Key is in the upper half
            }
            else
            {
                high = mid - 1; // Key is in the lower half
            }
        }

        return -1; // Key not found
    }
}
