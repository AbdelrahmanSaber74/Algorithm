class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 2, 4, 6, 1, 3, 9, 7 };

        InsertionSort insertionSorter = new InsertionSort();
        SelectionSort selectionSorter = new SelectionSort();

        // Sorting with Insertion Sort
        int[] arrayInsertionSort = (int[])array.Clone(); // Create a copy for insertion sort
        Console.WriteLine("Array before insertion sort:");
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
