using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Найдите количество положительных целых чисел, квадрат которых меньше A");
            int A;
            Console.WriteLine("Введите число A: ");
            A = Convert.ToInt32(Console.ReadLine());
            int squaredNumberLessA = 1;
            while(squaredNumberLessA * squaredNumberLessA < A)
            {
                squaredNumberLessA++;

            }
            Console.WriteLine($"{squaredNumberLessA - 1} - количество чисел, " +
                $"квадрат которых меньше {A} ");

        }
    }
}
