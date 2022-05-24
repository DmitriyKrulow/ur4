using System;

namespace SmallestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limitation = 100;
            bool СheckFlag = false;
            int NumberElements = 0;
            int SeparateElement = int.MaxValue;
            int VerificationNumber;
            int[] SequenceElements;

            while (!СheckFlag || NumberElements > Limitation)
            {
                Console.Clear();
                Console.WriteLine("Введите количество ЭЛЕМЕНТОВ в массиве " +
                                  $"положительное число меньше {Limitation}");
                Console.ForegroundColor = ConsoleColor.Green;
                СheckFlag = int.TryParse(Console.ReadLine().Trim(), out NumberElements);
                Console.ResetColor();
            }
            SequenceElements = new int[NumberElements];
            for (int i = 0; i < NumberElements; i++)
            {
                Console.Clear();
                Console.WriteLine($"Введите значение элемента {i + 1} ");
                СheckFlag = int.TryParse(Console.ReadLine().Trim(), out SequenceElements[i]);
                if (!СheckFlag) i--;
                // Проверка
                if (SequenceElements[i] < SeparateElement)
                {
                    SeparateElement = SequenceElements[i];
                }
            }
            // Поиск наимешьнего значение в цикле
            VerificationNumber = int.MaxValue;
            foreach (int item in SequenceElements)
            {
                if (VerificationNumber > item)
                {
                    VerificationNumber = item;
                }
            }
            Console.WriteLine("______________________________________\n" +
                              " Определение во время ввода данных");
            Console.WriteLine(SeparateElement);
            Console.WriteLine("--------------------------------------\n" +
                              " Поиск среди элементов массива");
            Console.WriteLine(VerificationNumber);
            Console.ReadLine();
        }
    }
}
