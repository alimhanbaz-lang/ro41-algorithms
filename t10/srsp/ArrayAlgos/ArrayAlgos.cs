using System;

public static class ArrayAlgos
{
    // 1. Проверка на сортировку по возрастанию
    public static bool IsSorted(int[] a)
    {
        if (a == null) return true;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] > a[i + 1])
                return false;
        }
        return true;
    }

    // 2. Сортировка пузырьком на месте с флажком раннего выхода
    public static int BubbleSort(int[] a)
    {
        if (a == null || a.Length <= 1) return 0;
        int comparisons = 0;
        int n = a.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                comparisons++;
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break; // Ранний выход, если массив уже отсортирован
        }

        return comparisons;
    }

    // 3. Количество вхождений через два бинарных поиска
    public static int CountOccurrences(int[] sortedA, int x)
    {
        if (sortedA == null || sortedA.Length == 0) return 0;

        int leftIndex = FindLowerBound(sortedA, x);
        int rightIndex = FindUpperBound(sortedA, x);

        return rightIndex - leftIndex;
    }

    // Первый индекс, где элемент >= x
    private static int FindLowerBound(int[] a, int x)
    {
        int l = 0, r = a.Length;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (a[mid] >= x)
                r = mid;
            else
                l = mid + 1;
        }
        return l;
    }

    // Первый индекс, где элемент > x
    private static int FindUpperBound(int[] a, int x)
    {
        int l = 0, r = a.Length;
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (a[mid] > x)
                r = mid;
            else
                l = mid + 1;
        }
        return l;
    }
}
