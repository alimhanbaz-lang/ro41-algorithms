using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Установка кодировки для корректного отображения кириллицы
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введите количество секунд (целое неотрицательное число): ");
            string input = Console.ReadLine();

            // Проверка на корректность ввода (не число или отрицательное число)
            if (!int.TryParse(input, out int totalSeconds) || totalSeconds < 0)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Требуется целое неотрицательное число.");
                return;
            }

            // Вычисления согласно алгоритму
            int hours = totalSeconds / 3600;
            int remainder = totalSeconds % 3600;
            int minutes = remainder / 60;
            int seconds = remainder % 60;

            // Вывод результата
            Console.WriteLine($"Результат: {hours} ч. {minutes} мин. {seconds} сек.");
        }
    }
}