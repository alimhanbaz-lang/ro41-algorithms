using System;

namespace CountDigitsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введите целое неотрицательное число n: ");
            string input = Console.ReadLine();

            // Защита от некорректного ввода
            if (!int.TryParse(input, out int n) || n < 0)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Требуется целое неотрицательное число.");
                return;
            }

            int count = 0;
            int temp = n; // Сохраняем исходное число для красивого вывода

            // Особый случай для нуля (у числа 0 ровно 1 цифра)
            if (n == 0)
            {
                count = 1;
            }
            else
            {
                // Цикл while для подсчета цифр путем деления на 10
                while (n > 0)
                {
                    n /= 10;
                    count++;
                }
            }

            Console.WriteLine($"Результат: в числе {temp} количество цифр равно {count}.");
        }
    }
}