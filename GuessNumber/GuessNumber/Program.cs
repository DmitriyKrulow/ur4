using System;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limitation = 100;
            bool СheckFlag = false;
            int VerificationNumber = 0;
            int BoundaryNumbers = 0;
            int HiddenNumber;
            string UserInput;
            Random NumberRandom = new Random();

            while (!СheckFlag || BoundaryNumbers > Limitation)
            {
                screensavers();
                Console.WriteLine("Введите границу для диапазона загадываемого числа " +
                                  $"положительное число меньше {Limitation}");
                Console.ForegroundColor = ConsoleColor.Green;
                СheckFlag = int.TryParse(Console.ReadLine().Trim(), out BoundaryNumbers);
                Console.ResetColor();
            }
            СheckFlag = false;
            HiddenNumber = NumberRandom.Next(BoundaryNumbers + 1);
            while (true)
            {
                screensavers();
                Console.WriteLine($"Введите число из диапазона от 0 до {BoundaryNumbers}.");
                Console.ForegroundColor = ConsoleColor.Green;
                UserInput = Console.ReadLine();
                if (UserInput == "") break;
                СheckFlag = int.TryParse(UserInput.Trim(), out VerificationNumber);
                Console.ResetColor();
                if (!СheckFlag || VerificationNumber > BoundaryNumbers) continue;
                if (VerificationNumber == HiddenNumber)
                {
                    Console.WriteLine("Победа!");
                    break;
                }
                else
                {
                    Console.WriteLine("Не угадано.");
                    if (VerificationNumber < HiddenNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    Console.WriteLine("Нажмите любую клавишу чтобы повторить попытку.");
                    Console.ReadKey();
                }
            }
            Console.WriteLine($"Загадано было число {HiddenNumber}.");
            Console.ReadKey();

            // Заставка
            void screensavers()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("     Игра «Угадай число»     ");
                Console.ResetColor();
            }
        }
    }
}
