using System;

namespace Sort3Project
{
    public static class Order
    {
        // Метод меняет местами значения двух переменных с помощью ref
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Метод упорядочивает три числа по возрастанию, используя только Swap
        public static void Sort3(ref int a, ref int b, ref int c)
        {
            if (a > b) Swap(ref a, ref b);
            if (b > c) Swap(ref b, ref c);
            if (a > b) Swap(ref a, ref b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Проверка заданных троек: 3 1 2; 1 2 3; 3 2 1; 2 2 1; 5 5 5
            TestSort(3, 1, 2);
            TestSort(1, 2, 3);
            TestSort(3, 2, 1);
            TestSort(2, 2, 1);
            TestSort(5, 5, 5);
        }

        static void TestSort(int a, int b, int c)
        {
            int origA = a, origB = b, origC = c;
            Order.Sort3(ref a, ref b, ref c);
            Console.WriteLine($"{origA} {origB} {origC} -> {a} {b} {c}");
        }
    }
}
