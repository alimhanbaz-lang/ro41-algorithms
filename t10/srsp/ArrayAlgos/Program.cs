using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Тестирование BubbleSort ===");
        
        // Массивы для проверки из задания
        int[][] testArrays = new int[][]
        {
            new int[] { },
            new int[] { 5 },
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 },
            new int[] { 3, 1, 3, 2, 3 }
        };

        foreach (var arr in testArrays)
        {
            Console.WriteLine($"До: [{string.Join(", ", arr)}]");
            bool sortedBefore = ArrayAlgos.IsSorted(arr);
            
            int comparisons = ArrayAlgos.BubbleSort(arr);
            
            Console.WriteLine($"После: [{string.Join(", ", arr)}]");
            Console.WriteLine($"IsSorted: {sortedBefore} | Число сравнений: {comparisons}");
            Console.WriteLine(new string('-', 35));
        }

        // Проверка на отсортированном массиве из 1000 элементов (ожидается 999 сравнений)
        int[] largeSorted = new int[1000];
        for (int i = 0; i < 1000; i++) 
        {
            largeSorted[i] = i;
        }
        int largeComparisons = ArrayAlgos.BubbleSort(largeSorted);
        Console.WriteLine($"Массив из 1000 элементов: число сравнений = {largeComparisons} (ожидается 999)");

        Console.WriteLine("\n=== Тестирование CountOccurrences ===");
        int[] sortedA = { 1, 2, 2, 2, 5, 7 };
        int[] targets = { 2, 1, 7, 3, 9 };

        foreach (int x in targets)
        {
            int count = ArrayAlgos.CountOccurrences(sortedA, x);
            Console.WriteLine($"x = {x} -> количество вхождений: {count}");
        }
    }
}
