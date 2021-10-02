using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число. " +
                "Найти количество нечетных цифр этого числа.\n");
            Console.WriteLine("Введите число");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int counter = 0;
            while (userNum != 0)
            {
                remainder = userNum % 10;
                userNum /= 10;
                if (remainder % 2 == 1)
                    counter++;
            }
            Console.WriteLine($"\nКоличество нечётных чисел введённого числа - {counter}");
        }
    }
}
