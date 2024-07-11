class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 2, 4, 6, 1, 3, 9, 7 };

        BubbleSort bubbleSorter = new BubbleSort();
        InsertionSort insertionSorter = new InsertionSort();
        SelectionSort selectionSorter = new SelectionSort();

        // Sorting with Bubble Sort
        int[] arrayBubbleSort = (int[])array.Clone(); // Create a copy for bubble sort
        Console.WriteLine("Array before bubble sort:");
        bubbleSorter.PrintArray(arrayBubbleSort);
        bubbleSorter.BubbleSortAlgorithm(arrayBubbleSort);
        Console.WriteLine("Array after bubble sort:");
        bubbleSorter.PrintArray(arrayBubbleSort);

        // Sorting with Insertion Sort
        int[] arrayInsertionSort = (int[])array.Clone(); // Create a copy for insertion sort
        Console.WriteLine("\nArray before insertion sort:");
        insertionSorter.PrintArray(arrayInsertionSort);
        insertionSorter.InsertionSortAlgorithm(arrayInsertionSort);
        Console.WriteLine("Array after insertion sort:");
        insertionSorter.PrintArray(arrayInsertionSort);

        // Sorting with Selection Sort
        int[] arraySelectionSort = (int[])array.Clone(); // Create a copy for selection sort
        Console.WriteLine("\nArray before selection sort:");
        selectionSorter.PrintArray(arraySelectionSort);
        selectionSorter.SelectionSortAlgorithm(arraySelectionSort);
        Console.WriteLine("Array after selection sort:");
        selectionSorter.PrintArray(arraySelectionSort);

    }
}
