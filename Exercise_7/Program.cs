using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 2 числа. " +
                "Найти их наибольший общий делитель используя алгоритм Евклида.\n");

            /*
            Большее число делим на меньшее.
            Если делится без остатка, то меньшее число и есть НОД (следует выйти из цикла).
            Если есть остаток, то большее число заменяем на меньшее.
            Меньшее заменяем на остаток от деления.
            Переходим к пункту 1.
             */
            int firstNum, secondNum, max, min;
            Console.WriteLine("Введите первое число: ");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            secondNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum < secondNum)
            {
                min = firstNum;
                max = secondNum;
            }
            else
            {
                min = secondNum;
                max = firstNum;
            }

            int remainder;
            while (max%min != 0)
            {
                remainder = max % min;
                max = min;
                min = remainder;
            }
            Console.WriteLine($"\nНОД ({firstNum}, {secondNum}) = {min}");
        }
    }
}
