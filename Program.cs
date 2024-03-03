using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Array array = new Array(arr);

        Console.WriteLine("Max: " + array.Max());
        Console.WriteLine("Min: " + array.Min());
        Console.WriteLine("Avg: " + array.Avg());
        Console.WriteLine("Search for 3: " + array.Search(3));
        Console.WriteLine("Search for 10: " + array.Search(10));
    }
}
