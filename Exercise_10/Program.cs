using System;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число. Найти число, которое является " +
                "зеркальным отображением последовательности цифр заданного числа, " +
                "например, задано число 123, вывести 321. \n");

            Console.WriteLine("Введите число");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int counter = 0;
            while (userNum != 0)
            {
                remainder = userNum % 10;
                userNum /= 10;
                counter = counter*10 + remainder;
            }
            Console.WriteLine($"\nЗеркальное отражение введённого числа - {counter}");
        }
    }
}
