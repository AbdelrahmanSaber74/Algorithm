class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 2, 4, 6, 1, 3 , 9 , 7 };

        InsertionSortExample sorter = new InsertionSortExample();

        Console.WriteLine("Array before sorting:");
        sorter.PrintArray(array);

        sorter.InsertionSort(array);

        Console.WriteLine("Array after sorting:");
        sorter.PrintArray(array);
    }
}
