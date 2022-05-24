using System;

namespace RandomMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberRows = 0;
            int NumberColumns = 0;
            int SumNumbers = 0;
            int Limitation = 70;// Ограничение ради наглядного отображения с учетом максимально допустимого количества символов в строке
            bool СheckFlag = false;
            Random NumberRandom = new Random();
            int[,] NumberMatrix;
            // Ввод значений
            while (!СheckFlag || NumberRows > Limitation)
            {
                Console.Clear();
                Console.WriteLine("Введите количество СТРОК в будущей матрице " +
                                  $"положительное число меньше {Limitation}");
                Console.ForegroundColor = ConsoleColor.Green;
                СheckFlag = int.TryParse(Console.ReadLine().Trim(), out NumberRows);
                Console.ResetColor();
            }
            СheckFlag = false;
            while (!СheckFlag || NumberColumns > Limitation)
            {
                Console.Clear();
                Console.WriteLine("Введите количество СТОЛБЦОВ в будущей матрице " +
                                  $"положительное число меньше {Limitation}");
                Console.ForegroundColor = ConsoleColor.Green;
                СheckFlag = int.TryParse(Console.ReadLine().Trim(), out NumberColumns);
                Console.ResetColor();
            }
            // Создание матрицы с случайными значениями
            Console.Clear();
            NumberMatrix = new int[NumberRows, NumberColumns];
            for (int i = 0; i < NumberRows; i++)
            {
                for (int i2 = 0; i2 < NumberColumns; i2++)
                {
                    NumberMatrix[i, i2] = NumberRandom.Next(100);
                    SumNumbers += NumberMatrix[i, i2];
                    Console.Write($"{NumberMatrix[i, i2]:00} ");
                }
                Console.Write("\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("--------------------------------------------------\n" +
                          $" Сумма всех числовых элементов матрицы равна : {SumNumbers}\n");
            Console.ResetColor();
        }
    }
}
