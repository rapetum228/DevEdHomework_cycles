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
            int squared_number_less_A = 1;
            while(squared_number_less_A*squared_number_less_A < A)
            {
                squared_number_less_A++;

            }
            Console.WriteLine($"{squared_number_less_A - 1} - количество чисел, " +
                $"квадрат которых меньше {A} ");

        }
    }
}
