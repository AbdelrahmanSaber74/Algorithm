class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        //BubbleSort bubbleSorter = new BubbleSort();
        //InsertionSort insertionSorter = new InsertionSort();
        //SelectionSort selectionSorter = new SelectionSort();
        //MergeSort mergeSorter = new MergeSort();

        //// Sorting with Bubble Sort
        //int[] arrayBubbleSort = (int[])array.Clone(); // Create a copy for bubble sort
        //Console.WriteLine("Array before bubble sort:");
        //bubbleSorter.PrintArray(arrayBubbleSort);
        //bubbleSorter.BubbleSortAlgorithm(arrayBubbleSort);
        //Console.WriteLine("Array after bubble sort:");
        //bubbleSorter.PrintArray(arrayBubbleSort);

        //// Sorting with Insertion Sort
        //int[] arrayInsertionSort = (int[])array.Clone(); // Create a copy for insertion sort
        //Console.WriteLine("\nArray before insertion sort:");
        //insertionSorter.PrintArray(arrayInsertionSort);
        //insertionSorter.InsertionSortAlgorithm(arrayInsertionSort);
        //Console.WriteLine("Array after insertion sort:");
        //insertionSorter.PrintArray(arrayInsertionSort);

        //// Sorting with Selection Sort
        //int[] arraySelectionSort = (int[])array.Clone(); // Create a copy for selection sort
        //Console.WriteLine("\nArray before selection sort:");
        //selectionSorter.PrintArray(arraySelectionSort);
        //selectionSorter.SelectionSortAlgorithm(arraySelectionSort);
        //Console.WriteLine("Array after selection sort:");
        //selectionSorter.PrintArray(arraySelectionSort);



        //// Sorting with Merge Sort
        //int[] arrayMergeSort = (int[])array.Clone(); // Create a copy for merge sort
        //Console.WriteLine("\nArray before merge sort:");
        //mergeSorter.PrintArray(arrayMergeSort);
        //mergeSorter.MergeSortAlgorithm(arrayMergeSort, 0, arrayMergeSort.Length - 1);
        //Console.WriteLine("Array after merge sort:");
        //mergeSorter.PrintArray(arrayMergeSort);


        // Instantiate BinarySearch
        BinarySearch br = new BinarySearch();
        // Search for the key
        int key = 42;
        int result = br.BinarySearchAlgorithm(array, key);
        // Display the result
        if (result != -1)
        {
            Console.WriteLine($"Key {key} found at index {result}.");
        }
        else
        {
            Console.WriteLine($"Key {key} not found in the array.");
        }


    }
}
