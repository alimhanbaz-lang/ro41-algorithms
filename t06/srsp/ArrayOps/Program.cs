using System;

class Program
{
    static void Main()
    {
        int[][] testArrays = new int[][]
        {
            new int[] { 4, 1, 7, 3, 9 },
            new int[] { 5 },
            new int[] { -2, -7, -4 },
            new int[] { 2, 2, 2 }
        };

        foreach (var arr in testArrays)
        {
            int[] original = (int[])arr.Clone();

            int sum = ArrayOps.Sum(arr);
            int minIndex = ArrayOps.IndexOfMin(arr);
            int greaterCount = ArrayOps.CountGreater(arr, 2);

            ArrayOps.Reverse(arr);

            Console.WriteLine($"Исходный массив: [{string.Join(", ", original)}]");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Индекс минимального: {minIndex}");
            Console.WriteLine($"Элементов больше 2: {greaterCount}");
            Console.WriteLine($"После Reverse: [{string.Join(", ", arr)}]");
            Console.WriteLine(new string('-', 30));
        }
    }
}
