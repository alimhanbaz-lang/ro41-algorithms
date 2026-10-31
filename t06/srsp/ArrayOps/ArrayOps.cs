public static class ArrayOps
{
    // 1. Сумма элементов массива
    public static int Sum(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }

    // 2. Индекс первого минимального элемента (без Math.Min, начальное значение — из массива)
    public static int IndexOfMin(int[] a)
    {
        if (a == null || a.Length == 0) return -1;
        
        int minIndex = 0;
        int minVal = a[0];
        
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < minVal)
            {
                minVal = a[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    // 3. Количество элементов больше x
    public static int CountGreater(int[] a, int x)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > x)
            {
                count++;
            }
        }
        return count;
    }

    // 4. Разворот массива на месте (без Array.Reverse)
    public static void Reverse(int[] a)
    {
        int left = 0;
        int right = a.Length - 1;
        
        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;
            
            left++;
            right--;
        }
    }
}
