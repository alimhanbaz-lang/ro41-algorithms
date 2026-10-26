using System;

namespace Sort3App
{
    public static class Order
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Sort3(ref int a, ref int b, ref int c)
        {
            if (a > b) Swap(ref a, ref b);
            if (b > c) Swap(ref b, ref c);
            if (a > b) Swap(ref a, ref b);
        }
    }

    class Program
    {
        static void RunTest(int a, int b, int c)
        {
            int origA = a, origB = b, origC = c;
            Order.Sort3(ref a, ref b, ref c);
            Console.WriteLine($"{origA} {origB} {origC} -> {a} {b} {c}");
        }

        static void Main(string[] args)
        {
            RunTest(3, 1, 2);
            RunTest(1, 2, 3);
            RunTest(3, 2, 1);
            RunTest(2, 2, 1);
            RunTest(5, 5, 5);
        }
    }
}
